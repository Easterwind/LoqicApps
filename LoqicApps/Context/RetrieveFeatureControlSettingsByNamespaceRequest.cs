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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("RetrieveFeatureControlSettingsByNamespace")]
	public partial class RetrieveFeatureControlSettingsByNamespaceRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string NamespaceName
		{
			get
			{
				if (this.Parameters.Contains("NamespaceName"))
				{
					return ((string)(this.Parameters["NamespaceName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["NamespaceName"] = value;
			}
		}
		
		public RetrieveFeatureControlSettingsByNamespaceRequest()
		{
			this.RequestName = "RetrieveFeatureControlSettingsByNamespace";
			this.NamespaceName = default(string);
		}
	}
}