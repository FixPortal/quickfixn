#region Using Directives

#endregion

namespace QuickFix.Enhancements.DataDictionary
{
	public interface IQFCoreSetup
	{
		ExternalDictionary GetDataDictionary(int revision, string sessionDescription, bool defaultVersionSupported, FixVersion fixVersion);
		FixVersion GetFixVersion(string beginString);
	}
}