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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("CreatePolymorphicLookupAttribute")]
	public partial class CreatePolymorphicLookupAttributeRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string SolutionUniqueName
		{
			get
			{
				if (this.Parameters.Contains("SolutionUniqueName"))
				{
					return ((string)(this.Parameters["SolutionUniqueName"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["SolutionUniqueName"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.Metadata.OneToManyRelationshipMetadata[] OneToManyRelationships
		{
			get
			{
				if (this.Parameters.Contains("OneToManyRelationships"))
				{
					return ((Microsoft.Xrm.Sdk.Metadata.OneToManyRelationshipMetadata[])(this.Parameters["OneToManyRelationships"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.Metadata.OneToManyRelationshipMetadata[]);
				}
			}
			set
			{
				this.Parameters["OneToManyRelationships"] = value;
			}
		}
		
		public Microsoft.Xrm.Sdk.Metadata.LookupAttributeMetadata Lookup
		{
			get
			{
				if (this.Parameters.Contains("Lookup"))
				{
					return ((Microsoft.Xrm.Sdk.Metadata.LookupAttributeMetadata)(this.Parameters["Lookup"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.Metadata.LookupAttributeMetadata);
				}
			}
			set
			{
				this.Parameters["Lookup"] = value;
			}
		}
		
		public CreatePolymorphicLookupAttributeRequest()
		{
			this.RequestName = "CreatePolymorphicLookupAttribute";
			this.OneToManyRelationships = default(Microsoft.Xrm.Sdk.Metadata.OneToManyRelationshipMetadata[]);
			this.Lookup = default(Microsoft.Xrm.Sdk.Metadata.LookupAttributeMetadata);
		}
	}
}