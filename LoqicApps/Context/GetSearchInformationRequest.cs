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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("GetSearchInformation")]
	public partial class GetSearchInformationRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string Fetchxml
		{
			get
			{
				if (this.Parameters.Contains("Fetchxml"))
				{
					return ((string)(this.Parameters["Fetchxml"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["Fetchxml"] = value;
			}
		}
		
		public GetSearchInformationRequest()
		{
			this.RequestName = "GetSearchInformation";
			this.Fetchxml = default(string);
		}
	}
}