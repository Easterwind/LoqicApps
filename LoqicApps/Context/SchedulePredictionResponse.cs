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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("SchedulePrediction")]
	public partial class SchedulePredictionResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public SchedulePredictionResponse()
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
	}
}