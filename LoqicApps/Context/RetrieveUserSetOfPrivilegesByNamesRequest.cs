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
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/crm/2011/Contracts")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("RetrieveUserSetOfPrivilegesByNames")]
	public partial class RetrieveUserSetOfPrivilegesByNamesRequest : Microsoft.Xrm.Sdk.OrganizationRequest
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
		
		public string[] PrivilegeNames
		{
			get
			{
				if (this.Parameters.Contains("PrivilegeNames"))
				{
					return ((string[])(this.Parameters["PrivilegeNames"]));
				}
				else
				{
					return default(string[]);
				}
			}
			set
			{
				this.Parameters["PrivilegeNames"] = value;
			}
		}
		
		public RetrieveUserSetOfPrivilegesByNamesRequest()
		{
			this.RequestName = "RetrieveUserSetOfPrivilegesByNames";
			this.UserId = default(System.Guid);
			this.PrivilegeNames = default(string[]);
		}
	}
}