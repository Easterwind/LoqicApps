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
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/crm/2011/Contracts")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("RetrieveEnvironmentVariableValue")]
	public partial class RetrieveEnvironmentVariableValueRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string DefinitionSchemaName
		{
			get
			{
				if (this.Parameters.Contains("DefinitionSchemaName"))
				{
					return ((string)(this.Parameters["DefinitionSchemaName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["DefinitionSchemaName"] = value;
			}
		}
		
		public RetrieveEnvironmentVariableValueRequest()
		{
			this.RequestName = "RetrieveEnvironmentVariableValue";
			this.DefinitionSchemaName = default(string);
		}
	}
}