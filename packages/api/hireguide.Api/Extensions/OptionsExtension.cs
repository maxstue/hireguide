namespace hireguide.Api.Extensions;

internal static class OptionsExtension
{
    internal static IServiceCollection AddCustomOptions(this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
        // .ConfigureAndValidateSingleton<ApplicationOptions>(configuration)
        // .ConfigureAndValidateSingleton<JwtOptions>(configuration.GetSection(nameof(ApplicationOptions.Jwt)))
        // .ConfigureAndValidateSingleton<CacheProfileOptions>(
        // 	configuration.GetSection(nameof(ApplicationOptions.CacheProfiles)))
        // .ConfigureAndValidateSingleton<CompressionOptions>(
        // 	configuration.GetSection(nameof(ApplicationOptions.Compression)))
        // // .ConfigureAndValidateSingleton<ForwardedHeadersOptions>(
        // // 	configuration.GetSection(nameof(ApplicationOptions.ForwardedHeaders)))
        // // .Configure<ForwardedHeadersOptions>(options =>
        // // {
        // // 	options.KnownNetworks.Clear();
        // // 	options.KnownProxies.Clear();
        // // })
        // .ConfigureAndValidateSingleton<GraphQlOptions>(
        // 	configuration.GetSection(nameof(ApplicationOptions.GraphQl)))
        // .ConfigureAndValidateSingleton<RequestExecutorOptions>(configuration
        // 	.GetSection(nameof(ApplicationOptions.GraphQl))
        // 	.GetSection(nameof(GraphQlOptions.Request)));
    }
}