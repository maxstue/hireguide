namespace hireguide.Api.Extensions;

public static class ServiceExtension
{
    public static IServiceCollection AddApiLayer(this IServiceCollection services, IHostEnvironment environment,
        IConfiguration configuration)
    {
        services.AddControllers();
        services.AddCustomOptions(configuration)
            .AddCustomGraphQl(configuration);
        return services;
    }
}