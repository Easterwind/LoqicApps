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
	public enum SynapseLinkEntitySyncState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Completed", 3, "#0000ff", "Completed")]
		Completed = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("CompletedWithFailures", 4, "#0000ff", "Completed with failures")]
		CompletedWithFailures = 8,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("InProgress", 2, "#0000ff", "In progress")]
		InProgress = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("None", 0, "#0000ff", "None")]
		None = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("NotStarted", 1, "#0000ff", "Not started")]
		NotStarted = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Paused", 6, "#0000ff", "Paused")]
		Paused = 32,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("PostProcessing", 7, "#0000ff", "Post processing")]
		PostProcessing = 64,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("RequestedInitialData", 5, "#0000ff", "Requested initial data")]
		RequestedInitialData = 16,
	}
}