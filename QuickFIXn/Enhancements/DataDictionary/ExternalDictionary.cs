#region Using Directives

using System.Xml;
using System.Xml.Linq;

#endregion

namespace QuickFix.Enhancements.DataDictionary
{
	public class ExternalDictionary
	{
		public XDocument Data { get; set; }
		public XmlDocument Definition { get; set; }
		public XmlDocument TransportDefinition { get; set; }
		public VersionInfo Version { get; set; }
	}
}