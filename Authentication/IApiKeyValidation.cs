namespace VideogameStatsApi.Authentication
{
    //Reference: Used to create IApiKeyValidation - https://youtu.be/0mb-wkkVMbg?si=dsH0wDqkdh8rmrTm&t=137
    public interface IApiKeyValidation
    {
        // Checks if the API key is valid
        bool IsValidApiKey (string userApiKey);
    }
}