using Microsoft.AspNetCore.Builder;

namespace app.utils.Middlewares
{
    public static class MiddlewareExtensions
    {
       public static IApplicationBuilder UseModularApplication(
          this IApplicationBuilder builder)
       {
          return builder.UseMiddleware<ModularApplicationMiddleware>();
       }
    }
}