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
	public enum WorkflowDependency_Type
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Argument Entity that workflow depends on", 8)]
		ArgumentEntitythatworkflowdependson = 9,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Attribute definition that workflow depends on", 7)]
		Attributedefinitionthatworkflowdependson = 8,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Custom entity definition that workflow depends on", 6)]
		Customentitydefinitionthatworkflowdependson = 7,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Local parameter", 1)]
		Localparameter = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Primary entity", 2)]
		Primaryentity = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Primary entity - after SDK operation", 4)]
		PrimaryentityafterSDKoperation = 5,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Primary entity - before SDK operation", 3)]
		PrimaryentitybeforeSDKoperation = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Related entity", 5)]
		Relatedentity = 6,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Sdk association", 0)]
		Sdkassociation = 1,
	}
}