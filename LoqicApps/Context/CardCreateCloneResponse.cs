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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("CardCreateClone")]
	public partial class CardCreateCloneResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public CardCreateCloneResponse()
		{
		}
		
		public string CardIdClone
		{
			get
			{
				if (this.Results.Contains("CardIdClone"))
				{
					return ((string)(this.Results["CardIdClone"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
}