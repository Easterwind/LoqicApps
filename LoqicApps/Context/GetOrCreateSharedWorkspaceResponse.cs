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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("GetOrCreateSharedWorkspace")]
	public partial class GetOrCreateSharedWorkspaceResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public GetOrCreateSharedWorkspaceResponse()
		{
		}
		
		public Microsoft.Xrm.Sdk.Entity target
		{
			get
			{
				if (this.Results.Contains("target"))
				{
					return ((Microsoft.Xrm.Sdk.Entity)(this.Results["target"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.Entity);
				}
			}
		}
	}
}