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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_CheckForCustomizedSitemap")]
	public partial class msdyn_CheckForCustomizedSitemapResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public msdyn_CheckForCustomizedSitemapResponse()
		{
		}
		
		public string Helplink
		{
			get
			{
				if (this.Results.Contains("Helplink"))
				{
					return ((string)(this.Results["Helplink"]));
				}
				else
				{
					return default(string);
				}
			}
		}
		
		public string Message
		{
			get
			{
				if (this.Results.Contains("Message"))
				{
					return ((string)(this.Results["Message"]));
				}
				else
				{
					return default(string);
				}
			}
		}
		
		public string ResultEntities
		{
			get
			{
				if (this.Results.Contains("ResultEntities"))
				{
					return ((string)(this.Results["ResultEntities"]));
				}
				else
				{
					return default(string);
				}
			}
		}
		
		public int ReturnLevel
		{
			get
			{
				if (this.Results.Contains("ReturnLevel"))
				{
					return ((int)(this.Results["ReturnLevel"]));
				}
				else
				{
					return default(int);
				}
			}
		}
		
		public int ReturnSeverity
		{
			get
			{
				if (this.Results.Contains("ReturnSeverity"))
				{
					return ((int)(this.Results["ReturnSeverity"]));
				}
				else
				{
					return default(int);
				}
			}
		}
		
		public int ReturnStatus
		{
			get
			{
				if (this.Results.Contains("ReturnStatus"))
				{
					return ((int)(this.Results["ReturnStatus"]));
				}
				else
				{
					return default(int);
				}
			}
		}
	}
}