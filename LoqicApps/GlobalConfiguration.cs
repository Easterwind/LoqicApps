using LogiqApps.Plugin;

namespace LogiqApps
{
    public static class GlobalConfiguration
    {
        public const string ResultField = "jsonresult";
        public const string EntityName = "ipg_portalquery";
        public const string QueryName = "ipg_query";
        public const string QueryParameters = "ipg_parameters";
        public const PluginStage PluginStage = LogiqApps.Plugin.PluginStage.PostOperation;
        public const string Message = PluginMessage.RETRIEVE_MULTIPLE;
    }
}
