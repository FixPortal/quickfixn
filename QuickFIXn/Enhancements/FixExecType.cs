#region Using Directives

#endregion

namespace QuickFix.Enhancements
{
	public struct FixExecType
	{
		public int? Id { get; set; }
		public int FixVersion { get; set; }
		public string TagValue { get; set; }
		public string TagDescription { get; set; }
		public bool TreatAsPending { get; set; }
	}
}