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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("RunDataProcessingModule")]
	public partial class RunDataProcessingModuleRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string[] ScalarInputs
		{
			get
			{
				if (this.Parameters.Contains("ScalarInputs"))
				{
					return ((string[])(this.Parameters["ScalarInputs"]));
				}
				else
				{
					return default(string[]);
				}
			}
			set
			{
				this.Parameters["ScalarInputs"] = value;
			}
		}
		
		public string Script
		{
			get
			{
				if (this.Parameters.Contains("Script"))
				{
					return ((string)(this.Parameters["Script"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Script"] = value;
			}
		}
		
		public string[] UpstreamResults
		{
			get
			{
				if (this.Parameters.Contains("UpstreamResults"))
				{
					return ((string[])(this.Parameters["UpstreamResults"]));
				}
				else
				{
					return default(string[]);
				}
			}
			set
			{
				this.Parameters["UpstreamResults"] = value;
			}
		}
		
		public string OverrideApplicationId
		{
			get
			{
				if (this.Parameters.Contains("OverrideApplicationId"))
				{
					return ((string)(this.Parameters["OverrideApplicationId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["OverrideApplicationId"] = value;
			}
		}
		
		public string[] EndPoints
		{
			get
			{
				if (this.Parameters.Contains("EndPoints"))
				{
					return ((string[])(this.Parameters["EndPoints"]));
				}
				else
				{
					return default(string[]);
				}
			}
			set
			{
				this.Parameters["EndPoints"] = value;
			}
		}
		
		public string DataProcessingConfigurationId
		{
			get
			{
				if (this.Parameters.Contains("DataProcessingConfigurationId"))
				{
					return ((string)(this.Parameters["DataProcessingConfigurationId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["DataProcessingConfigurationId"] = value;
			}
		}
		
		public string CallbackUri
		{
			get
			{
				if (this.Parameters.Contains("CallbackUri"))
				{
					return ((string)(this.Parameters["CallbackUri"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["CallbackUri"] = value;
			}
		}
		
		public string JobName
		{
			get
			{
				if (this.Parameters.Contains("JobName"))
				{
					return ((string)(this.Parameters["JobName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["JobName"] = value;
			}
		}
		
		public string[] JobArguments
		{
			get
			{
				if (this.Parameters.Contains("JobArguments"))
				{
					return ((string[])(this.Parameters["JobArguments"]));
				}
				else
				{
					return default(string[]);
				}
			}
			set
			{
				this.Parameters["JobArguments"] = value;
			}
		}
		
		public RunDataProcessingModuleRequest()
		{
			this.RequestName = "RunDataProcessingModule";
			this.DataProcessingConfigurationId = default(string);
		}
	}
}