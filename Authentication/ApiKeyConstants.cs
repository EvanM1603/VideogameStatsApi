namespace VideogameStatsApi.Authentication
{
    //Reference: Used to create the constants - https://youtu.be/0mb-wkkVMbg?si=T1KAT8mzo_i7vuE7&t=112
    public static class ApiKeyConstants
    {
        // The name of the header passing the API Key
        public const string ApiKeyHeaderName = "X-API-KEY";
        // The key in appsettings.json
        public const string ApiKeyConfigName = "ApiKey";
    }
}