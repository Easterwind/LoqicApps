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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_CreateNewAnalysisJobForRuleSet")]
	public partial class msdyn_CreateNewAnalysisJobForRuleSetRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public Microsoft.Xrm.Sdk.EntityReference SolutionHealthRuleSet
		{
			get
			{
				if (this.Parameters.Contains("SolutionHealthRuleSet"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["SolutionHealthRuleSet"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["SolutionHealthRuleSet"] = value;
			}
		}
		
		public string TriggerType
		{
			get
			{
				if (this.Parameters.Contains("TriggerType"))
				{
					return ((string)(this.Parameters["TriggerType"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["TriggerType"] = value;
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
		
		public msdyn_CreateNewAnalysisJobForRuleSetRequest()
		{
			this.RequestName = "msdyn_CreateNewAnalysisJobForRuleSet";
			this.SolutionHealthRuleSet = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
}