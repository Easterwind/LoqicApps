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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_dataprovideroperations")]
	public partial class msdyn_dataprovideroperationsRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string msdyn_recordid
		{
			get
			{
				if (this.Parameters.Contains("msdyn_recordid"))
				{
					return ((string)(this.Parameters["msdyn_recordid"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["msdyn_recordid"] = value;
			}
		}
		
		public string msdyn_httpmethod
		{
			get
			{
				if (this.Parameters.Contains("msdyn_httpmethod"))
				{
					return ((string)(this.Parameters["msdyn_httpmethod"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["msdyn_httpmethod"] = value;
			}
		}
		
		public string msdyn_payload
		{
			get
			{
				if (this.Parameters.Contains("msdyn_payload"))
				{
					return ((string)(this.Parameters["msdyn_payload"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["msdyn_payload"] = value;
			}
		}
		
		public msdyn_dataprovideroperationsRequest()
		{
			this.RequestName = "msdyn_dataprovideroperations";
			this.msdyn_httpmethod = default(string);
		}
	}
}