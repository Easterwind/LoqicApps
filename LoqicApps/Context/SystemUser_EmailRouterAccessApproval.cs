//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrmEarlyBound
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SystemUser_EmailRouterAccessApproval
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Approved", 1)]
		Approved = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Empty", 0)]
		Empty = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Pending Approval", 2)]
		PendingApproval = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Rejected", 3)]
		Rejected = 3,
	}
}