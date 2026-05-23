#region Using Directives

#endregion

namespace QuickFix.Enhancements
{
	internal interface ISupportsEntityId<T>
	{
		T EntityID { get; set; }
	}
}