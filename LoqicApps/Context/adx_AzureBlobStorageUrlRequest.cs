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
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/adx/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("adx_AzureBlobStorageUrl")]
	public partial class adx_AzureBlobStorageUrlRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public Microsoft.Xrm.Sdk.EntityReference Annotation
		{
			get
			{
				if (this.Parameters.Contains("Annotation"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["Annotation"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["Annotation"] = value;
			}
		}
		
		public adx_AzureBlobStorageUrlRequest()
		{
			this.RequestName = "adx_AzureBlobStorageUrl";
		}
	}
}