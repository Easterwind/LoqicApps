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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("pbi_GetEnvironmentWorkspaceAccessForUser")]
	public partial class pbi_GetEnvironmentWorkspaceAccessForUserRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public System.Guid pbi_UserObjectId
		{
			get
			{
				if (this.Parameters.Contains("pbi_UserObjectId"))
				{
					return ((System.Guid)(this.Parameters["pbi_UserObjectId"]));
				}
				else
				{
					return default(System.Guid);
				}
			}
			set
			{
				this.Parameters["pbi_UserObjectId"] = value;
			}
		}
		
		public pbi_GetEnvironmentWorkspaceAccessForUserRequest()
		{
			this.RequestName = "pbi_GetEnvironmentWorkspaceAccessForUser";
		}
	}
}