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
	public enum bot_accesscontrolpolicy
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Any", 0, "#0000ff", "Any signed in user is allowed to interact with the bot.")]
		Any = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Chatbot readers", 1, "#0000ff", "Authentication mode must be Integrated or Custom Azure Active Directory. User mus" +
			"t have at least Read access to the Chatbot record.")]
		Chatbotreaders = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Group membership", 2, "#0000ff", "Authentication mode must be Integrated or Custom Azure Active Directory. To inter" +
			"act with the bot, users must be member of one of the security groups configured " +
			"in the Authorized Security Groups field OR have Read access to the Chatbot.")]
		Groupmembership = 2,
	}
}