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
	public enum ImportFile_ProcessingStatus
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Complex Transformation", 3)]
		ComplexTransformation = 4,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Import Complete", 10)]
		ImportComplete = 11,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Import Pass 1", 8)]
		ImportPass1 = 9,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Import Pass 2", 9)]
		ImportPass2 = 10,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Lookup Transformation", 4)]
		LookupTransformation = 5,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Not Started", 0)]
		NotStarted = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Owner Transformation", 6)]
		OwnerTransformation = 7,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Parsing", 1)]
		Parsing = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Parsing Complete", 2)]
		ParsingComplete = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Picklist Transformation", 5)]
		PicklistTransformation = 6,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Primary Key Transformation", 11)]
		PrimaryKeyTransformation = 12,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Transformation Complete", 7)]
		TransformationComplete = 8,
	}
}