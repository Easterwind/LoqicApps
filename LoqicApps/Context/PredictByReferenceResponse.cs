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
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011//")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("PredictByReference")]
	public partial class PredictByReferenceResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public PredictByReferenceResponse()
		{
		}
		
		public string response
		{
			get
			{
				if (this.Results.Contains("response"))
				{
					return ((string)(this.Results["response"]));
				}
				else
				{
					return default(string);
				}
			}
		}
		
		public Microsoft.Xrm.Sdk.Entity responsev2
		{
			get
			{
				if (this.Results.Contains("responsev2"))
				{
					return ((Microsoft.Xrm.Sdk.Entity)(this.Results["responsev2"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.Entity);
				}
			}
		}
	}
}