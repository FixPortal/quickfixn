using System;
using System.Collections.Generic;
using QuickFix.Enhancements.DataDictionary;
using QuickFix.Enhancements.Extensions;
using QuickFix.Logger;
using QuickFix.Store;
using QuickFix.Util;

namespace QuickFix;

/// <summary>
/// Creates a Session based on specified settings
/// </summary>
public class SessionFactory
{
    protected IApplication _application;
    protected IMessageStoreFactory _messageStoreFactory;
    internal IQuickFixLoggerFactory _loggerFactory;
    protected IMessageFactory _messageFactory;
    protected Dictionary<string, DataDictionary.DataDictionary> _dictionariesByPath = new();

    internal SessionFactory(
        IApplication app,
        IMessageStoreFactory storeFactory,
        IQuickFixLoggerFactory? loggerFactory = null,        
        IMessageFactory? messageFactory = null, 
        IQFCoreSetup? dictionaryLoader = null) //	CP Enhancement
    {
        // TODO: for V2, consider ONLY instantiating MessageFactory in the Create() method,
        //   and removing instance var _messageFactory altogether.
        //   This makes sense because we can't distinguish FIX50 versions here in this constructor,
        //   and thus can't create the right FIX-Version factory because we don't know what
        //   session to use to look up the BeginString and DefaultApplVerID.

        _application = app;
        _messageStoreFactory = storeFactory;
        _loggerFactory = loggerFactory ?? NullQuickFixLoggerFactory.Instance;
        _messageFactory = messageFactory ?? new DefaultMessageFactory();

        #region CP Enhancement
        Console.WriteLine("[SessionFactory] " + _messageFactory.GetType().FullName);
        _dataDictionaryResolver =
            new Dictionary<DataDictionarySource,
                Func<DictionarySourceParameter, DataDictionary.DataDictionary>>
            {
                { DataDictionarySource.File, ConstructDictionaryFromFile },
                { DataDictionarySource.Database, ConstructDictionaryFromDatabase }
            };
        _dictionaryLoader = dictionaryLoader;
        #endregion
    }

    private static bool DetectIfInitiator(SettingsDictionary settings)
    {
        switch (settings.GetString(SessionSettings.CONNECTION_TYPE))
        {
            case "acceptor": return false;
            case "initiator": return true;
        }

        throw new ConfigError("Invalid ConnectionType");
    }

    public Session Create(SessionID sessionId, SettingsDictionary settings)
    {
        #region CP Enhancement

        var defaultDataDictionarySupported = false;
        var dataDictionarySource = DataDictionarySource.File;
        var dataDictionaryRevision = 1;

        // FixPortal Enhancement: for FIXT sessions, resolve FixVersion from the application version (DefaultApplVerID)
        // rather than the transport BeginString, so downstream code gets the correct application version ID
        var fixVersionSource = sessionId.IsFIXT && settings.Has(SessionSettings.DEFAULT_APPLVERID)
            ? settings.GetString(SessionSettings.DEFAULT_APPLVERID)
            : sessionId.BeginString;
        sessionId.FixVersion = _dictionaryLoader?.GetFixVersion(fixVersionSource);

        #endregion

        bool isInitiator = SessionFactory.DetectIfInitiator(settings);

        if (!isInitiator && settings.Has(SessionSettings.SESSION_QUALIFIER))
            throw new ConfigError("SessionQualifier cannot be used with acceptor.");

        bool useDataDictionary = true;
        if (settings.Has(SessionSettings.USE_DATA_DICTIONARY))
        {
            useDataDictionary = settings.GetBool(SessionSettings.USE_DATA_DICTIONARY);

            #region CP Enhancement

            if (useDataDictionary)
            {
                defaultDataDictionarySupported = settings.GetBool(SessionSettings.DATA_DICTIONARY_DEFAULT_SUPPORTED);
                dataDictionaryRevision = settings.GetIntOrDefault(SessionSettings.DATA_DICTIONARY_REVISION, dataDictionaryRevision);
                dataDictionarySource = settings.GetEnumValue(SessionSettings.DATA_DICTIONARY_SOURCE, dataDictionarySource);
            }

            #endregion
        }

        QuickFix.Fields.ApplVerID? defaultApplVerId = null;
        IMessageFactory sessionMsgFactory = _messageFactory;
        if (sessionId.IsFIXT)
        {
            if (!settings.Has(SessionSettings.DEFAULT_APPLVERID))
            {
                throw new ConfigError("ApplVerID is required for FIXT transport");
            }

            string rawDefaultApplVerIdSetting = settings.GetString(SessionSettings.DEFAULT_APPLVERID);

            defaultApplVerId = Message.GetApplVerID(rawDefaultApplVerIdSetting);

            // DefaultMessageFactory as created in the SessionFactory ctor cannot
            // tell the difference between FIX50 versions (same BeginString, unknown defaultApplVerId).
            // But we have the real session settings here, so we can fix that.
            // This is, of course, kind of a hack, and it should be reworked (TODO!).
            if (_messageFactory is DefaultMessageFactory)
            {
                sessionMsgFactory = new DefaultMessageFactory(
                    FixValues.ApplVerID.FromBeginString(rawDefaultApplVerIdSetting));
            }
        }

        DataDictionaryProvider dd = new DataDictionaryProvider();
        if (useDataDictionary)
        {
            if (sessionId.IsFIXT)
                ProcessFixTDataDictionaries(sessionId, settings, dd, dataDictionarySource, dataDictionaryRevision, defaultDataDictionarySupported); // FixPortal Enhancement
            else
                ProcessFixDataDictionary(sessionId, settings, dd, dataDictionarySource, dataDictionaryRevision, defaultDataDictionarySupported); // FixPortal Enhancement
        }

        int heartBtInt = 0;
        if (isInitiator)
        {
            heartBtInt = System.Convert.ToInt32(settings.GetLong(SessionSettings.HEARTBTINT));
            if (heartBtInt < 0)
                throw new ConfigError($"{SessionSettings.HEARTBTINT} must be greater or equal to zero");
        }
        string senderDefaultApplVerId = "";
        if(defaultApplVerId is not null)
            senderDefaultApplVerId = defaultApplVerId.Value;

        Session session = new Session(
            isInitiator,
            _application,
            _messageStoreFactory,
            sessionId,
            dd,
            new SessionSchedule(settings),
            heartBtInt,
            _loggerFactory,
            sessionMsgFactory,
            senderDefaultApplVerId);

        if (settings.Has("MillisecondsInTimeStamp")) {
            throw new ApplicationException(
                "Setting 'MillisecondsInTimeStamp' was removed.  Use 'TimestampPrecision=Milliseconds' instead.");
        }

        if (settings.Has("Encoding")){
            CharEncoding.SetEncoding(settings.GetString(SessionSettings.ENCODING));
        }

        if (settings.Has(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS))
            session.SendRedundantResendRequests = settings.GetBool(SessionSettings.SEND_REDUNDANT_RESENDREQUESTS);
        if (settings.Has(SessionSettings.RESEND_SESSION_LEVEL_REJECTS))
            session.ResendSessionLevelRejects = settings.GetBool(SessionSettings.RESEND_SESSION_LEVEL_REJECTS);
        /* FIXME - implement optional settings
        if (settings.Has(SessionSettings.CHECK_COMPID))
            session.SetCheckCompId(settings.GetBool(SessionSettings.CHECK_COMPID));
         */
        if (settings.Has(SessionSettings.CHECK_LATENCY))
            session.CheckLatency = settings.GetBool(SessionSettings.CHECK_LATENCY);
        if (settings.Has(SessionSettings.MAX_LATENCY))
            session.MaxLatency = settings.GetInt(SessionSettings.MAX_LATENCY);
        if (settings.Has(SessionSettings.LOGON_TIMEOUT))
            session.LogonTimeout = settings.GetInt(SessionSettings.LOGON_TIMEOUT);
        if (settings.Has(SessionSettings.LOGOUT_TIMEOUT))
            session.LogoutTimeout = settings.GetInt(SessionSettings.LOGOUT_TIMEOUT);
        if (settings.Has(SessionSettings.RESET_ON_LOGON))
            session.ResetOnLogon = settings.GetBool(SessionSettings.RESET_ON_LOGON);
        if (settings.Has(SessionSettings.RESET_ON_LOGOUT))
            session.ResetOnLogout = settings.GetBool(SessionSettings.RESET_ON_LOGOUT);
        if (settings.Has(SessionSettings.RESET_ON_DISCONNECT))
            session.ResetOnDisconnect = settings.GetBool(SessionSettings.RESET_ON_DISCONNECT);
        if (settings.Has(SessionSettings.REFRESH_ON_LOGON))
            session.RefreshOnLogon = settings.GetBool(SessionSettings.REFRESH_ON_LOGON);
        if (settings.Has(SessionSettings.PERSIST_MESSAGES))
            session.PersistMessages = settings.GetBool(SessionSettings.PERSIST_MESSAGES);
        if( settings.Has( SessionSettings.TIMESTAMP_PRECISION ) )
            session.TimeStampPrecision = settings.GetTimeStampPrecision( SessionSettings.TIMESTAMP_PRECISION );
        if (settings.Has(SessionSettings.ENABLE_LAST_MSG_SEQ_NUM_PROCESSED))
            session.EnableLastMsgSeqNumProcessed = settings.GetBool(SessionSettings.ENABLE_LAST_MSG_SEQ_NUM_PROCESSED);
        if (settings.Has(SessionSettings.MAX_MESSAGES_IN_RESEND_REQUEST))
            session.MaxMessagesInResendRequest = settings.GetULong(SessionSettings.MAX_MESSAGES_IN_RESEND_REQUEST);
        if (settings.Has(SessionSettings.SEND_LOGOUT_BEFORE_TIMEOUT_DISCONNECT))
            session.SendLogoutBeforeTimeoutDisconnect = settings.GetBool(SessionSettings.SEND_LOGOUT_BEFORE_TIMEOUT_DISCONNECT);
        if (settings.Has(SessionSettings.IGNORE_POSSDUP_RESEND_REQUESTS))
            session.IgnorePossDupResendRequests = settings.GetBool(SessionSettings.IGNORE_POSSDUP_RESEND_REQUESTS);
        if (settings.Has(SessionSettings.VALIDATE_LENGTH_AND_CHECKSUM))
            session.ValidateLengthAndChecksum = settings.GetBool(SessionSettings.VALIDATE_LENGTH_AND_CHECKSUM);
        if (settings.Has(SessionSettings.RESETSEQUENCE_MESSAGE_REQUIRES_ORIGSENDINGTIME))
            session.RequiresOrigSendingTime = settings.GetBool(SessionSettings.RESETSEQUENCE_MESSAGE_REQUIRES_ORIGSENDINGTIME);

        return session;
    }

    #region CP Enhancement

    protected readonly IQFCoreSetup? _dictionaryLoader;

    protected readonly
        Dictionary<DataDictionarySource,
            Func<DictionarySourceParameter, DataDictionary.DataDictionary>> _dataDictionaryResolver;

    private DataDictionary.DataDictionary ConstructDictionaryFromDatabase(DictionarySourceParameter sourceParameter)
    {
        try
        {
            bool isTransport = sourceParameter.SettingsKey == SessionSettings.TRANSPORT_DATA_DICTIONARY;
            string cacheKey = isTransport
                ? $"{sourceParameter.SessionDescription}::transport"
                : sourceParameter.SessionDescription;

            if (!_dictionariesByPath.TryGetValue(cacheKey, out var dd) && _dictionaryLoader != null)
            {
                var externalDictionary =
                    _dictionaryLoader.GetDataDictionary(sourceParameter.Revision, sourceParameter.SessionDescription,
                        sourceParameter.DefaultDataDictionarySupported, sourceParameter.FixVersion);

                // FixPortal Enhancement: use transport definition when loading the transport dictionary
                var definition = isTransport && externalDictionary.TransportDefinition != null
                    ? externalDictionary.TransportDefinition
                    : externalDictionary.Definition;

                dd = new DataDictionary.DataDictionary(definition)
                {
                    Data = externalDictionary.Data,
                    DictionaryID = externalDictionary.Version.Id,
                    Name = externalDictionary.Version.Name,
                    Revision = sourceParameter.Revision,
                    SessionDescription = sourceParameter.SessionDescription
                };
                _dictionariesByPath[cacheKey] = dd;
            }

            return dd;
        }
        catch (Exception ex)
        {
            throw new Enhancements.Exceptions.DictionaryMissingException(
                $"Unable to construct dictionary for session: {sourceParameter.Description}", ex);
        }
    }

    private DataDictionary.DataDictionary ConstructDictionaryFromFile(DictionarySourceParameter sourceParameter)
    {
        var path = sourceParameter.Settings.Has(sourceParameter.SettingsKey)
            ? sourceParameter.Settings.GetString(sourceParameter.SettingsKey)
            : sourceParameter.BeginString.Replace(".", "") + ".xml";

        path = Enhancements.Utility.ParsePath(StringUtil.FixSlashes(path));

        if (!_dictionariesByPath.TryGetValue(path, out var dd))
        {
            dd = new DataDictionary.DataDictionary(path);
            _dictionariesByPath[path] = dd;
        }

        return dd;
    }

    #endregion

    protected DataDictionary.DataDictionary CreateDataDictionary(SessionID sessionID, SettingsDictionary settings, string settingsKey,
        string beginString, DataDictionarySource dataDictionarySource, int dataDictonaryVersion,
        bool defaultSupported)
    {
        #region CP Enhancement

        var sourceParameter = new DictionarySourceParameter
        {
            BeginString = beginString,
            Revision = dataDictonaryVersion,
            SessionDescription = sessionID.ToString(),
            Settings = settings,
            SettingsKey = settingsKey,
            DefaultDataDictionarySupported = defaultSupported,
            FixVersion = sessionID.FixVersion
        };
        var dd = _dataDictionaryResolver[dataDictionarySource](sourceParameter);

        #endregion

        DataDictionary.DataDictionary ddCopy = new DataDictionary.DataDictionary(dd);

        if (settings.Has(SessionSettings.VALIDATE_FIELDS_OUT_OF_ORDER))
            ddCopy.CheckFieldsOutOfOrder = settings.GetBool(SessionSettings.VALIDATE_FIELDS_OUT_OF_ORDER);
        if (settings.Has(SessionSettings.VALIDATE_FIELDS_HAVE_VALUES))
            ddCopy.CheckFieldsHaveValues = settings.GetBool(SessionSettings.VALIDATE_FIELDS_HAVE_VALUES);
        if (settings.Has(SessionSettings.VALIDATE_USER_DEFINED_FIELDS))
            ddCopy.CheckUserDefinedFields = settings.GetBool(SessionSettings.VALIDATE_USER_DEFINED_FIELDS);
        if (settings.Has(SessionSettings.ALLOW_UNKNOWN_ENUM_VALUES))
            ddCopy.AllowUnknownEnumValues = settings.GetBool(SessionSettings.ALLOW_UNKNOWN_ENUM_VALUES);
        if (settings.Has(SessionSettings.ALLOW_UNKNOWN_MSG_FIELDS))
            ddCopy.AllowUnknownMessageFields = settings.GetBool(SessionSettings.ALLOW_UNKNOWN_MSG_FIELDS);

        #region CP Enhancement
        
        if (settings.Has(SessionSettings.ALLOW_STRING_TRUNCATION_FOR_CHAR_FIELDS))
            ddCopy.AllowStringTruncationForCharFields = settings.GetBool(SessionSettings.ALLOW_STRING_TRUNCATION_FOR_CHAR_FIELDS);

        #endregion

        return ddCopy;
    }

    protected void ProcessFixTDataDictionaries(SessionID sessionId, SettingsDictionary settings, DataDictionaryProvider provider,  DataDictionarySource dataDictionarySource, int dataDictionaryVersion, bool defaultSupported) // FixPortal Enhancement
    {
        provider.AddTransportDataDictionary(sessionId.BeginString, CreateDataDictionary(sessionId, settings, SessionSettings.TRANSPORT_DATA_DICTIONARY, sessionId.BeginString, dataDictionarySource,  dataDictionaryVersion, defaultSupported)); // FixPortal Enhancement

        foreach (KeyValuePair<string, string> setting in settings)
        {
            if (setting.Key.StartsWith(SessionSettings.APP_DATA_DICTIONARY, System.StringComparison.CurrentCultureIgnoreCase))
            {
                if (setting.Key.Equals(SessionSettings.APP_DATA_DICTIONARY, System.StringComparison.CurrentCultureIgnoreCase))
                {
                    Fields.ApplVerID applVerId = Message.GetApplVerID(settings.GetString(SessionSettings.DEFAULT_APPLVERID));
                    DataDictionary.DataDictionary dd =  CreateDataDictionary(sessionId, settings, SessionSettings.APP_DATA_DICTIONARY, sessionId.BeginString, dataDictionarySource, dataDictionaryVersion, defaultSupported); // FixPortal Enhancement
                    provider.AddApplicationDataDictionary(applVerId.Value, dd);
                }
                else
                {
                    int offset = setting.Key.IndexOf('.');
                    if (offset == -1)
                        throw new ArgumentException(
                            $"Malformed {SessionSettings.APP_DATA_DICTIONARY} : {setting.Key}");

                    string beginStringQualifier = setting.Key.Substring(offset);
                    DataDictionary.DataDictionary dd =  CreateDataDictionary(sessionId, settings, setting.Key, beginStringQualifier, dataDictionarySource, dataDictionaryVersion, defaultSupported); // FixPortal Enhancement
                    provider.AddApplicationDataDictionary(Message.GetApplVerID(beginStringQualifier).Value, dd);
                }
            }
        }
    }

    protected void ProcessFixDataDictionary(SessionID sessionId, SettingsDictionary settings, DataDictionaryProvider provider, DataDictionarySource dataDictionarySource, int dataDictionaryVersion, bool defaultSupported) // FixPortal Enhancement
    {
        DataDictionary.DataDictionary dataDictionary = CreateDataDictionary(sessionId, settings, SessionSettings.DATA_DICTIONARY, sessionId.BeginString, dataDictionarySource, dataDictionaryVersion, defaultSupported); // FixPortal Enhancement
        provider.AddTransportDataDictionary(sessionId.BeginString, dataDictionary);
        provider.AddApplicationDataDictionary(FixValues.ApplVerID.FromBeginString(sessionId.BeginString), dataDictionary);
    }
}

