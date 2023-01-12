using Newtonsoft.Json;

namespace LogiqApps.Helpers
{
    public static class JsonHelper
    {
        public static string CustomJsonErrorResponse(string errorMessage)
        {
            return JsonConvert.SerializeObject(new
            {
                Status = false,
                Error = errorMessage
            });
        }
    }
}
