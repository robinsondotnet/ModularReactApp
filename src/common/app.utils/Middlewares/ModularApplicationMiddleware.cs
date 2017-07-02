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
            var fullRequestPath = context.Request.Path;
            var requestPath = fullRequestPath.HasValue?fullRequestPath.Value.Replace("/", string.Empty):"";
            // Validate requestPath
            if (fullRequestPath.HasValue && _options.Endpoints.ContainsKey(requestPath))
            {
                var provider = context.RequestServices.GetService<IResponseProvider>();
                var response = await provider.GetBodyAsync(_options.Endpoints[requestPath]);
                provider.SetBody(response);
            }
            // Continue to the next action
            await this._next.Invoke(context);
        }

    }
}