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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("PvaGetFeatureControlSet")]
	public partial class PvaGetFeatureControlSetResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public PvaGetFeatureControlSetResponse()
		{
		}
		
		public string FeatureControlSet
		{
			get
			{
				if (this.Results.Contains("FeatureControlSet"))
				{
					return ((string)(this.Results["FeatureControlSet"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
}