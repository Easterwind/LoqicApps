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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("TriggerDesktopFlowRunCallback")]
	public partial class TriggerDesktopFlowRunCallbackResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public TriggerDesktopFlowRunCallbackResponse()
		{
		}
		
		public int callbackHttpResponseCode
		{
			get
			{
				if (this.Results.Contains("callbackHttpResponseCode"))
				{
					return ((int)(this.Results["callbackHttpResponseCode"]));
				}
				else
				{
					return default(int);
				}
			}
		}
	}
}