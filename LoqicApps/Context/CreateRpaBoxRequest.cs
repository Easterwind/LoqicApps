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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("CreateRpaBox")]
	public partial class CreateRpaBoxRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public Microsoft.Xrm.Sdk.EntityReference machineImageVersionId
		{
			get
			{
				if (this.Parameters.Contains("machineImageVersionId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["machineImageVersionId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["machineImageVersionId"] = value;
			}
		}
		
		public string machineName
		{
			get
			{
				if (this.Parameters.Contains("machineName"))
				{
					return ((string)(this.Parameters["machineName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["machineName"] = value;
			}
		}
		
		public string machineDescription
		{
			get
			{
				if (this.Parameters.Contains("machineDescription"))
				{
					return ((string)(this.Parameters["machineDescription"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["machineDescription"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.EntityReference machineNetworkId
		{
			get
			{
				if (this.Parameters.Contains("machineNetworkId"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["machineNetworkId"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["machineNetworkId"] = value;
			}
		}
		
		public CreateRpaBoxRequest()
		{
			this.RequestName = "CreateRpaBox";
			this.machineImageVersionId = default(Microsoft.Xrm.Sdk.EntityReference);
			this.machineName = default(string);
		}
	}
}