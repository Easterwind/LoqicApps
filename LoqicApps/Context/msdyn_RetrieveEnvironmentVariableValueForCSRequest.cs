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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_RetrieveEnvironmentVariableValueForCS")]
	public partial class msdyn_RetrieveEnvironmentVariableValueForCSRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string msdyn_EnvironmentVariableName
		{
			get
			{
				if (this.Parameters.Contains("msdyn_EnvironmentVariableName"))
				{
					return ((string)(this.Parameters["msdyn_EnvironmentVariableName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["msdyn_EnvironmentVariableName"] = value;
			}
		}
		
		public msdyn_RetrieveEnvironmentVariableValueForCSRequest()
		{
			this.RequestName = "msdyn_RetrieveEnvironmentVariableValueForCS";
			this.msdyn_EnvironmentVariableName = default(string);
		}
	}
}