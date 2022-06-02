using Microsoft.AspNetCore.Mvc.Testing;
using System;
using Xunit;
using boot_camp2;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace Tests
{
    public class LocationTest { 
        [Fact]
    public async Task HelloWorldTest()
    {
        var application = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder =>
            {
                //builder.ConfigureTestServices(services =>
                //{
                //    services.AddScoped<ILogger, Class1>();
                //});
                // ... Configure test services
            });
            //
            // Arrange
            var client = application.CreateClient();

            // Act
            var response = await client.GetAsync("/api/Location/patientid/555");

            // Assert
            response.EnsureSuccessStatusCode();
        }
}
}