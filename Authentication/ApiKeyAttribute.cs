using Microsoft.AspNetCore.Mvc;

namespace VideogameStatsApi.Authentication
{
    public class ApiKeyAttribute :ServiceFilterAttribute
    {
        public ApiKeyAttribute() : base(typeof(ApiKeyAuthFilter))
        {       
        }
    }
}