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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("RetrieveFlowUpdates")]
	public partial class RetrieveFlowUpdatesRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string ObjectId
		{
			get
			{
				if (this.Parameters.Contains("ObjectId"))
				{
					return ((string)(this.Parameters["ObjectId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["ObjectId"] = value;
			}
		}
		
		public RetrieveFlowUpdatesRequest()
		{
			this.RequestName = "RetrieveFlowUpdates";
			this.ObjectId = default(string);
		}
	}
}