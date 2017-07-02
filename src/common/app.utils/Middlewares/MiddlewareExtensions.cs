using Microsoft.AspNetCore.Builder;

namespace app.utils.Middlewares
{
    public static class MiddlewareExtensions
    {
       public static IApplicationBuilder UseModularApplication(
          this IApplicationBuilder builder, ModularApplicationMiddlewareOptions options)
       {
          return builder.UseMiddleware<ModularApplicationMiddleware>(options);
       }
    }
}