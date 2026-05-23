using System;

namespace QuickFix.Logger;

public class NullLogFactory : ILogFactory
{
    public NullLogFactory() { }

    public ILog Create(SessionID _x)
    {
        return new NullLog();
    }

    public ILog CreateNonSessionLog()
    {
        return new NullLog();
    }

    #region CP Enhancement

    public ILog Create(SessionID sessionID, Enhancements.DataDictionary.VersionInfo dataDictionaryVersionInfo)
    {
        return new NullLog();
    }

    #endregion
}