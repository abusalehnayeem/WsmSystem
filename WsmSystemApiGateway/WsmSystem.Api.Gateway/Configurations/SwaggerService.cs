using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace WsmSystem.Api.Gateway.Configurations
{
    public static class SwaggerService
    {
        public static IServiceCollection AddSwaggerService(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddSwaggerGen(s =>
            {
                // Register the Swagger generator, defining 1 or more Swagger documents
                s.SwaggerDoc(configuration.GetDocumentName(),
                    new OpenApiInfo
                        {Title = configuration.GetDocumentTitle(), Version = configuration.GetDocumentVersion()});
                s.AddSecurityDefinition(configuration.GetSecurity(), new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter into field the word 'Bearer' following by space and JWT",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                s.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                s.IncludeXmlComments(xmlPath, true);
            });
            return services;
        }
    }
}