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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_RunSolutionCheckerRules")]
	public partial class msdyn_RunSolutionCheckerRulesRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string AnalysisComponentId
		{
			get
			{
				if (this.Parameters.Contains("AnalysisComponentId"))
				{
					return ((string)(this.Parameters["AnalysisComponentId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["AnalysisComponentId"] = value;
			}
		}
		
		public bool InAppNotificationEnabled
		{
			get
			{
				if (this.Parameters.Contains("InAppNotificationEnabled"))
				{
					return ((bool)(this.Parameters["InAppNotificationEnabled"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Parameters["InAppNotificationEnabled"] = value;
			}
		}
		
		public msdyn_RunSolutionCheckerRulesRequest()
		{
			this.RequestName = "msdyn_RunSolutionCheckerRules";
		}
	}
}