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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_SaveCalendar")]
	public partial class msdyn_SaveCalendarRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public string CalendarEventInfo
		{
			get
			{
				if (this.Parameters.Contains("CalendarEventInfo"))
				{
					return ((string)(this.Parameters["CalendarEventInfo"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["CalendarEventInfo"] = value;
			}
		}
		
		public msdyn_SaveCalendarRequest()
		{
			this.RequestName = "msdyn_SaveCalendar";
			this.CalendarEventInfo = default(string);
		}
	}
}