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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("DetectLanguage")]
	public partial class DetectLanguageRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string text
		{
			get
			{
				if (this.Parameters.Contains("text"))
				{
					return ((string)(this.Parameters["text"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["text"] = value;
			}
		}
		
		public string modelId
		{
			get
			{
				if (this.Parameters.Contains("modelId"))
				{
					return ((string)(this.Parameters["modelId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["modelId"] = value;
			}
		}
		
		public string countryHint
		{
			get
			{
				if (this.Parameters.Contains("countryHint"))
				{
					return ((string)(this.Parameters["countryHint"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["countryHint"] = value;
			}
		}
		
		public DetectLanguageRequest()
		{
			this.RequestName = "DetectLanguage";
			this.text = default(string);
		}
	}
}