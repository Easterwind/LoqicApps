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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_CheckForDeletedSDKMessageProcessingSteps")]
	public partial class msdyn_CheckForDeletedSDKMessageProcessingStepsResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public msdyn_CheckForDeletedSDKMessageProcessingStepsResponse()
		{
		}
		
		public string HelpLink
		{
			get
			{
				if (this.Results.Contains("HelpLink"))
				{
					return ((string)(this.Results["HelpLink"]));
				}
				else
				{
					return default(string);
				}
			}
		}
		
		public string Message
		{
			get
			{
				if (this.Results.Contains("Message"))
				{
					return ((string)(this.Results["Message"]));
				}
				else
				{
					return default(string);
				}
			}
		}
		
		public string ResultEntities
		{
			get
			{
				if (this.Results.Contains("ResultEntities"))
				{
					return ((string)(this.Results["ResultEntities"]));
				}
				else
				{
					return default(string);
				}
			}
		}
		
		public int ReturnStatus
		{
			get
			{
				if (this.Results.Contains("ReturnStatus"))
				{
					return ((int)(this.Results["ReturnStatus"]));
				}
				else
				{
					return default(int);
				}
			}
		}
	}
}