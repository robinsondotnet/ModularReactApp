using System.IO;
using System.Threading.Tasks;
using app.utils.Middlewares;
using app.utils.Providers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Moq;
using Xunit;

namespace app.tests.infraestructure
{
    public class MiddlewareTests
    {
        [Fact]
        public async void Test1()
        {
            var provider = new RemoteResponseProvider();
            
            var middleware = new ModularApplicationMiddleware((innerHttpContext) =>
            {
                return Task.CompletedTask;
            }, new ModularApplicationMiddlewareOptions());

            await middleware.Invoke(new DefaultHttpContext());

        }
        
    }
}