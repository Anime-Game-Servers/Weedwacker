using Microsoft.AspNetCore.Http;
using Weedwacker.Shared.Authentication;
using Weedwacker.Shared.Utils;
using Weedwacker.WebServer.Authentication;

namespace Weedwacker.WebServer.Handlers
{
    internal class TokenVerify : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            // Parse body data.
            var bodyData = await context.Request.ReadFromJsonAsync<VerifyTokenRequestJson>();
            // Validate body data.
            if (bodyData == null)
                return false;

            // Pass data to authentication handler.
            var responseData = await WebServer.AuthenticationSystem.GetTokenAuthenticator()
                .Authenticate(IAuthenticationSystem.FromTokenRequest(context, bodyData));
            // Send response.
            await context.Response.WriteAsJsonAsync(responseData);

            // Log to console.
            Logger.WriteLine(string.Format("Verifying token from {0}", context.Connection.RemoteIpAddress));
            return true;
        }
    }
}
