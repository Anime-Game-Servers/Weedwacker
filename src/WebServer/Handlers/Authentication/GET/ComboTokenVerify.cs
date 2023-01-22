using Microsoft.AspNetCore.Http;
using Weedwacker.Shared.Utils;
using Weedwacker.WebServer.Authentication;

namespace Weedwacker.WebServer.Handlers
{
    internal class ComboTokenVerify : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            if (!await WebServer.AuthenticationSystem.GetComboTokenAuthenticator()
                    .Authenticate(IAuthenticationSystem.FromExternalRequest(context)))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                return false;
            }

            // Log to console.
            Logger.WriteLine(string.Format("Verifying combo token from {0}", context.Connection.RemoteIpAddress));
            return true;
        }
    }
}
