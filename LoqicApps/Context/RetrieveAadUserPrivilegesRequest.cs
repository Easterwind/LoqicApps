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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("RetrieveAadUserPrivileges")]
	public partial class RetrieveAadUserPrivilegesRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public System.Guid DirectoryObjectId
		{
			get
			{
				if (this.Parameters.Contains("DirectoryObjectId"))
				{
					return ((System.Guid)(this.Parameters["DirectoryObjectId"]));
				}
				else
				{
					return default(System.Guid);
				}
			}
			set
			{
				this.Parameters["DirectoryObjectId"] = value;
			}
		}
		
		public RetrieveAadUserPrivilegesRequest()
		{
			this.RequestName = "RetrieveAadUserPrivileges";
			this.DirectoryObjectId = default(System.Guid);
		}
	}
}