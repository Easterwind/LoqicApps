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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("CardCreateClone")]
	public partial class CardCreateCloneRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string CardId
		{
			get
			{
				if (this.Parameters.Contains("CardId"))
				{
					return ((string)(this.Parameters["CardId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["CardId"] = value;
			}
		}
		
		public string CardName
		{
			get
			{
				if (this.Parameters.Contains("CardName"))
				{
					return ((string)(this.Parameters["CardName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["CardName"] = value;
			}
		}
		
		public CardCreateCloneRequest()
		{
			this.RequestName = "CardCreateClone";
			this.CardId = default(string);
			this.CardName = default(string);
		}
	}
}