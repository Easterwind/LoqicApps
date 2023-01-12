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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("RetrieveCompositeDataSource")]
	public partial class RetrieveCompositeDataSourceRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string ChildSchemaName
		{
			get
			{
				if (this.Parameters.Contains("ChildSchemaName"))
				{
					return ((string)(this.Parameters["ChildSchemaName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["ChildSchemaName"] = value;
			}
		}
		
		public string ParentSchemaName
		{
			get
			{
				if (this.Parameters.Contains("ParentSchemaName"))
				{
					return ((string)(this.Parameters["ParentSchemaName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["ParentSchemaName"] = value;
			}
		}
		
		public RetrieveCompositeDataSourceRequest()
		{
			this.RequestName = "RetrieveCompositeDataSource";
			this.ChildSchemaName = default(string);
			this.ParentSchemaName = default(string);
		}
	}
}