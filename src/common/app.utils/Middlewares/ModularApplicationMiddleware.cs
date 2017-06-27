using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace app.utils.Middlewares
{
    public class ModularApplicationMiddleware
    {
        private readonly RequestDelegate _next;

        public ModularApplicationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            return this._next.Invoke(context);
        }

    }
}