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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("RetrieveUserSetOfPrivilegesByNames")]
	public partial class RetrieveUserSetOfPrivilegesByNamesResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public RetrieveUserSetOfPrivilegesByNamesResponse()
		{
		}
		
		public Microsoft.Crm.Sdk.Messages.RolePrivilege[] RolePrivileges
		{
			get
			{
				if (this.Results.Contains("RolePrivileges"))
				{
					return ((Microsoft.Crm.Sdk.Messages.RolePrivilege[])(this.Results["RolePrivileges"]));
				}
				else
				{
					return default(Microsoft.Crm.Sdk.Messages.RolePrivilege[]);
				}
			}
		}
	}
}