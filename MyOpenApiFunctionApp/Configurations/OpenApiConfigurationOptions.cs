using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Configurations;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyOpenApiFunctionApp.Configurations
{
    public class OpenApiConfigurationOptions : DefaultOpenApiConfigurationOptions
    {
        public override OpenApiInfo Info { get; set; } = new OpenApiInfo()
        {
            Version = "3.0.0",
            Title = "Open API Sample on Azure Functions (STATIC)",
            Description = "HTTP APIs that run on Azure Functions using Open API specification.",
            TermsOfService = new Uri("https://github.com/Azure/azure-functions-openapi-extension"),
            Contact = new OpenApiContact()
            {
                Name = "Microsoft Azure Function Team",
                Email = "funcdisc@microsoft.com",
                Url = new Uri("https://github.com/Azure/azure-functions-openapi-extension/issues"),
            },
            License = new OpenApiLicense()
            {
                Name = "MIT",
                Url = new Uri("http://opensource.org/licenses/MIT"),
            }
        };

        public override List<OpenApiServer> Servers { get; set; } = new List<OpenApiServer>()
        {
            new OpenApiServer() { Url = "https://contoso.com/api/" },
            new OpenApiServer() { Url = "https://fabrikam.com/api/" },
        };
    }
}
