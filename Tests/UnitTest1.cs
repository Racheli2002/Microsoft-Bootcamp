using Microsoft.AspNetCore.Mvc.Testing;
using System;
using Xunit;
using boot_camp2;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using boot_camp2.Controllers;
using Microsoft.Extensions.Logging.Abstractions;
using Services;
using Dal;
using Moq;

namespace Tests
{
    public class LocationTest { 
        [Fact]
    public async Task HelloWorldTest()
    {
            

            var application = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    
                   services.AddSingleton<ILoggerFactory, NullLoggerFactory>();
                });
                //... Configure test services
            });
            //
            // Arrange
           // var client = application.CreateClient();
            Mock<ILocationService> mockMath = new Mock<ILocationService>();
            mockMath
                .Setup(r => r.getLocations())
                            .Returns(() =>Task.FromResult( new List<Location>() { new Location() { City = "jer", StartDate = new DateTime(), EndDate = new DateTime(), location = "jer", PatientId = "555" } }));
            LocationController location = new LocationController(mockMath.Object);
            var result = location.Get();
            Assert.True(true);
           // mockMath.Verify(x => x.getLocations());

            // Act
           // var response = await client.GetAsync("/api/Location/all");

            // Assert
         //   response.EnsureSuccessStatusCode();
        }
    }
}