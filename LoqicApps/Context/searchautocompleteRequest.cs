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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("searchautocomplete")]
	public partial class searchautocompleteRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string entities
		{
			get
			{
				if (this.Parameters.Contains("entities"))
				{
					return ((string)(this.Parameters["entities"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["entities"] = value;
			}
		}
		
		public string filter
		{
			get
			{
				if (this.Parameters.Contains("filter"))
				{
					return ((string)(this.Parameters["filter"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["filter"] = value;
			}
		}
		
		public string options
		{
			get
			{
				if (this.Parameters.Contains("options"))
				{
					return ((string)(this.Parameters["options"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["options"] = value;
			}
		}
		
		public string propertybag
		{
			get
			{
				if (this.Parameters.Contains("propertybag"))
				{
					return ((string)(this.Parameters["propertybag"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["propertybag"] = value;
			}
		}
		
		public string search
		{
			get
			{
				if (this.Parameters.Contains("search"))
				{
					return ((string)(this.Parameters["search"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["search"] = value;
			}
		}
		
		public bool fuzzy
		{
			get
			{
				if (this.Parameters.Contains("fuzzy"))
				{
					return ((bool)(this.Parameters["fuzzy"]));
				}
				else
				{
					return default(bool);
				}
			}
			set
			{
				this.Parameters["fuzzy"] = value;
			}
		}
		
		public searchautocompleteRequest()
		{
			this.RequestName = "searchautocomplete";
			this.search = default(string);
		}
	}
}