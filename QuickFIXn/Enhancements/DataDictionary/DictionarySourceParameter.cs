#region Using Directives

#endregion

namespace QuickFix.Enhancements.DataDictionary
{
    public class DictionarySourceParameter
    {
        public SettingsDictionary Settings { get; set; }
        public string SettingsKey { get; set; }
        public string BeginString { get; set; }
        public string SessionDescription { get; set; }
        public int Revision { get; set; }
        public bool DefaultDataDictionarySupported { get; set; }
        public FixVersion FixVersion { get; set; }

        public string Description => $"BeginString: {BeginString}, SessionDescription: {SessionDescription}, Revision: {Revision}, DefaultSupported {DefaultDataDictionarySupported}, FixVersion: {FixVersion.Major}.{FixVersion.Minor}";
    }
}