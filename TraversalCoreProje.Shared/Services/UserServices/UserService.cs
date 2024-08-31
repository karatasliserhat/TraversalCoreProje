using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using TraversalCoreProje.Shared.Interfaces;

namespace TraversalCoreProje.Shared.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _context;

        public UserService(IHttpContextAccessor context)
        {
            _context = context;
        }

        public string GetUser => _context.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

        public string AccessToken => _context.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "accessToken")?.Value;

        public void TokenHeaderAuthorization(HttpClient httpClient, string Token)
        {
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(JwtBearerDefaults.AuthenticationScheme, Token);
        }
    }
}
