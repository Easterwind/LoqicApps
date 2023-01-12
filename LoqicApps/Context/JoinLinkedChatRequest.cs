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
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/new/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("JoinLinkedChat")]
	public partial class JoinLinkedChatRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public System.Guid UserId
		{
			get
			{
				if (this.Parameters.Contains("UserId"))
				{
					return ((System.Guid)(this.Parameters["UserId"]));
				}
				else
				{
					return default(System.Guid);
				}
			}
			set
			{
				this.Parameters["UserId"] = value;
			}
		}
		
		public string TeamsChatId
		{
			get
			{
				if (this.Parameters.Contains("TeamsChatId"))
				{
					return ((string)(this.Parameters["TeamsChatId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["TeamsChatId"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference RegardingEntity
		{
			get
			{
				if (this.Parameters.Contains("RegardingEntity"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["RegardingEntity"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["RegardingEntity"] = value;
			}
		}
		
		public JoinLinkedChatRequest()
		{
			this.RequestName = "JoinLinkedChat";
			this.UserId = default(System.Guid);
			this.TeamsChatId = default(string);
			this.RegardingEntity = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
}