using System.Net.Http;
using System.Threading.Tasks;
using app.utils.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace app.utils.Middlewares
{
    public class ModularApplicationMiddleware
    {
        private readonly RequestDelegate _next;
        private IResponseProvider _provider;

        public ModularApplicationMiddleware(RequestDelegate next, IResponseProvider provider = null)
        {
            _next = next;
            
            if (provider != null)
                _provider = provider;
        }

        public Task Invoke(HttpContext context)
        {
            if (_provider == null)
                _provider = context.RequestServices.GetService<IResponseProvider>();
            
            var requestPath = context.Request.Path;
            
            // Validate requestPath
            if (requestPath.HasValue && requestPath.Value.StartsWith("module1"))
            {
                // Get Response from module applications
                var tenant = new HttpClient();
                var response = tenant.GetStringAsync("http://localhost:5001/").Result;
                // Set into IResponseProvider
                _provider.SetBody(response);
            }
            // Continue to the next action
            return this._next.Invoke(context);
        }

    }
}