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
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("msdyn_MigrateSlaProactiveRun")]
	public partial class msdyn_MigrateSlaProactiveRunResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public msdyn_MigrateSlaProactiveRunResponse()
		{
		}
		
		public string Exception
		{
			get
			{
				if (this.Results.Contains("Exception"))
				{
					return ((string)(this.Results["Exception"]));
				}
				else
				{
					return default(string);
				}
			}
		}
		
		public string OutputString
		{
			get
			{
				if (this.Results.Contains("OutputString"))
				{
					return ((string)(this.Results["OutputString"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
}