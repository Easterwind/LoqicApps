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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_CheckForDeletedWebResources")]
	public partial class msdyn_CheckForDeletedWebResourcesRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string EntityIds
		{
			get
			{
				if (this.Parameters.Contains("EntityIds"))
				{
					return ((string)(this.Parameters["EntityIds"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["EntityIds"] = value;
			}
		}
		
		public string SolutionId
		{
			get
			{
				if (this.Parameters.Contains("SolutionId"))
				{
					return ((string)(this.Parameters["SolutionId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["SolutionId"] = value;
			}
		}
		
		public string ExcludeSolutionIds
		{
			get
			{
				if (this.Parameters.Contains("ExcludeSolutionIds"))
				{
					return ((string)(this.Parameters["ExcludeSolutionIds"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["ExcludeSolutionIds"] = value;
			}
		}
		
		public msdyn_CheckForDeletedWebResourcesRequest()
		{
			this.RequestName = "msdyn_CheckForDeletedWebResources";
		}
	}
}