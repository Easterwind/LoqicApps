using Microsoft.Xrm.Sdk;

namespace LogiqApps.Plugin
{
    public interface IUnitOfService
    {
        IPluginExecutionContext PluginExecutionContext { get; }
        IOrganizationService OrganizationService { get; }
        ITracingService TracingService { get; }
    }
}
