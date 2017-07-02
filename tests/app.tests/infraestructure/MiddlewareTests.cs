using System;
using System.Collections.Generic;
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
        public async void set_remote_response_into_service()
        {
            var context = new DefaultHttpContext();

            var stubProvider = new StubServiceProvider();
            var mock = new Mock<IResponseProvider>();

            mock.Setup(provider => provider.GetBodyAsync(It.IsAny<string>()))
                .ReturnsAsync("test body");
            
            stubProvider.AppendService(typeof(IResponseProvider), mock.Object);

            context.RequestServices = stubProvider;
            context.Request.Path = new PathString("/me");

            var options = new ModularApplicationMiddlewareOptions{
                Endpoints = new Dictionary<string, string>
                {
                    {"me", "http://localhost:5001"}
                }
            };
            
            var middleware = new ModularApplicationMiddleware((innerHttpContext) =>
            {
                return Task.CompletedTask;
            }, options); 

            await middleware.Invoke(context);

        }
        
    }
}