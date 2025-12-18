namespace VideogameStatsApi.Authentication
{
    // Reference:Used to create ApiKeyValidation - https://youtu.be/0mb-wkkVMbg?si=9Dx-2szmjVNwvjlS&t=153 
    public class ApiKeyValidation : IApiKeyValidation
    {
        private readonly IConfiguration _configuration;

        public ApiKeyValidation(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool IsValidApiKey(string userApiKey)
        {
            if (string.IsNullOrEmpty(userApiKey))
            {
                return false;
            }

            var apiKey = _configuration.GetValue<String>(ApiKeyConstants.ApiKeyConfigName);
            if (apiKey is null || apiKey != userApiKey )
                return false;      

            return true;
        }
    }
}