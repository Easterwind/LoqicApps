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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("UnschedulePrediction")]
	public partial class UnschedulePredictionRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string version
		{
			get
			{
				if (this.Parameters.Contains("version"))
				{
					return ((string)(this.Parameters["version"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["version"] = value;
			}
		}
		
		public bool skipStatusUpdate
		{
			get
			{
				if (this.Parameters.Contains("skipStatusUpdate"))
				{
					return ((bool)(this.Parameters["skipStatusUpdate"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Parameters["skipStatusUpdate"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference Target
		{
			get
			{
				if (this.Parameters.Contains("Target"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Target"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Target"] = value;
			}
		}
		
		public UnschedulePredictionRequest()
		{
			this.RequestName = "UnschedulePrediction";
			this.version = default(string);
			this.Target = default(Microsoft.Xrm.Sdk.EntityReference);
		}
	}
}