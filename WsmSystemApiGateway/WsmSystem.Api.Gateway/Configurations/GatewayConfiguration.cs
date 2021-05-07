using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WsmSystem.Api.Gateway.Configurations
{
    public static class GatewayConfiguration
    {
        public static string GetDocumentName(this IConfiguration configuration) => configuration["Swagger:Document:Name"];
        public static string GetDocumentTitle(this IConfiguration configuration) => configuration["Swagger:Document:Title"];
        public static string GetDocumentVersion(this IConfiguration configuration) => configuration["Swagger:Document:Version"];
        public static string GetEndpointUrl(this IConfiguration configuration) => configuration["Swagger:Endpoint:Url"];
        public static string GetEndpointName(this IConfiguration configuration) => configuration["Swagger:Endpoint:Name"];
        public static string GetSecurity(this IConfiguration configuration) => configuration["Swagger:Security"];
    }
}
