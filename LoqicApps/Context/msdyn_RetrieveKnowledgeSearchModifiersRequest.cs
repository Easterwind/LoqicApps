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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_RetrieveKnowledgeSearchModifiers")]
	public partial class msdyn_RetrieveKnowledgeSearchModifiersRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string RuntimeMode
		{
			get
			{
				if (this.Parameters.Contains("RuntimeMode"))
				{
					return ((string)(this.Parameters["RuntimeMode"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["RuntimeMode"] = value;
			}
		}
		
		public msdyn_RetrieveKnowledgeSearchModifiersRequest()
		{
			this.RequestName = "msdyn_RetrieveKnowledgeSearchModifiers";
		}
	}
}