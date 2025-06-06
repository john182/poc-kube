namespace PocKube.API;

using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public static class HealthCheck
{
    public static IServiceCollection AddHealthCheck(this IServiceCollection services)
    {
        services
            .AddHealthChecks()
           ;

        return services;
    }
    
    public static IApplicationBuilder UseHealthChecks(
        this IApplicationBuilder builder)
    {


        builder.UseHealthChecks(
            "/health",
            new HealthCheckOptions
            {
                Predicate = _ => true,
                ResponseWriter = HealthResponseWriter,
            });

        return builder;
    }
    
    
    private static Task HealthResponseWriter(HttpContext httpContext, HealthReport result) =>
        WriteResponseFor(httpContext, result);

    private static Task WriteResponseFor(HttpContext httpContext, HealthReport result)
    {
        httpContext.Response.ContentType = "application/json";


        var settings = new JsonSerializerSettings();
        settings.Converters.Add(new StringEnumConverter());
        settings.Converters.Add(new HealthCheckExceptionConverter());
        
        return httpContext.Response.WriteAsync(
            JsonConvert.SerializeObject(result, Formatting.Indented, settings));
    }
}