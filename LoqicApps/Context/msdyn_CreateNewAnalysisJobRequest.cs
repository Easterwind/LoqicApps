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
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/msdyn/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_CreateNewAnalysisJob")]
	public partial class msdyn_CreateNewAnalysisJobRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public Microsoft.Xrm.Sdk.EntityReferenceCollection ComponentInstances
		{
			get
			{
				if (this.Parameters.Contains("ComponentInstances"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReferenceCollection)(this.Parameters["ComponentInstances"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReferenceCollection);
				}
			}
			set
			{
				this.Parameters["ComponentInstances"] = value;
			}
		}
		
		public msdyn_CreateNewAnalysisJobRequest()
		{
			this.RequestName = "msdyn_CreateNewAnalysisJob";
		}
	}
}