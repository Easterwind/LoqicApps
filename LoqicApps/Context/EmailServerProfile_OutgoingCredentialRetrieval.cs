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
	public enum EmailServerProfile_OutgoingCredentialRetrieval
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Azure Active Directory OAuth", 7)]
		AzureActiveDirectoryOAuth = 7,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Credentials Specified by a User or Queue", 0)]
		CredentialsSpecifiedbyaUserorQueue = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Credentials Specified in Email Server Profile", 1)]
		CredentialsSpecifiedinEmailServerProfile = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Exchange Hybrid Modern Auth (HMA)", 6)]
		ExchangeHybridModernAuth_HMA = 6,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Gmail OAuth", 5)]
		GmailOAuth = 5,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Server to Server Authentication", 2)]
		ServertoServerAuthentication = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Windows Integrated Authentication", 3)]
		WindowsIntegratedAuthentication = 3,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Without Credentials (Anonymous)", 4)]
		WithoutCredentials_Anonymous = 4,
	}
}