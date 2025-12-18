using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace VideogameStatsApi.Authentication
{
    //Reference: Used to create ApiKeyAuthFilter - https://youtu.be/0mb-wkkVMbg?si=KWlZgHYKjzau_jCX&t=306
    public class ApiKeyAuthFilter : IAuthorizationFilter
    {
        private readonly IApiKeyValidation _apiKeyValidation;

        public ApiKeyAuthFilter(IApiKeyValidation apiKeyValidation)
        {
            _apiKeyValidation = apiKeyValidation; 
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var userApiKey = context.HttpContext.Request.Headers[ApiKeyConstants.ApiKeyHeaderName];

            if (string.IsNullOrEmpty(userApiKey))
            {
                context.Result = new BadRequestResult();

                return;
            }

            if (!_apiKeyValidation.IsValidApiKey(userApiKey)) 
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}