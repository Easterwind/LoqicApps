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
	public enum msdyn_knowledgemanagementsetting_msdyn_actionlist
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Link / unlink article", 0, "#0000ff")]
		Linkunlinkarticle = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Copy URL", 1, "#0000ff")]
		CopyURL = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Link article and email URL", 2, "#0000ff")]
		LinkarticleandemailURL = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Link article and send article content", 3, "#0000ff")]
		Linkarticleandsendarticlecontent = 3,
	}
}