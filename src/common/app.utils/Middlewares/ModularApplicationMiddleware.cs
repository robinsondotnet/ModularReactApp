using System.Net.Http;
using System.Threading.Tasks;
using app.utils.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace app.utils.Middlewares
{
    public class ModularApplicationMiddleware
    {
        private readonly RequestDelegate _next;

        private readonly ModularApplicationMiddlewareOptions _options;

        public ModularApplicationMiddleware(
            RequestDelegate next,
            ModularApplicationMiddlewareOptions options)
        {
            _next = next;
            _options = options;
        }

        public async Task Invoke(HttpContext context)
        {
            var provider = context.RequestServices.GetService<IResponseProvider>();
            
            
            var fullRequestPath = context.Request.Path;
            var requestPath = fullRequestPath.HasValue?fullRequestPath.Value.Replace("/", string.Empty):"";
            // Validate requestPath
            if (fullRequestPath.HasValue && _options.Endpoints.ContainsKey(requestPath))
            {
                // Get Response from module applications
                var tenant = new HttpClient();
                var response = await tenant.GetStringAsync(_options.Endpoints[requestPath]);
                // Set into IResponseProvider
                provider.SetBody(response);
            }
            // Continue to the next action
            await this._next.Invoke(context);
        }

    }
}