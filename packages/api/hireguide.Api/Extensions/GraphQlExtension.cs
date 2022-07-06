using hireguide.Api.GraphQl;
using hireguide.Application.Features.Projects;

namespace hireguide.Api.Extensions;

public static class GraphQlExtension
{
    public static IServiceCollection AddCustomGraphQl(this IServiceCollection services, IConfiguration configuration)
    {
        // var graphQlOptions = configuration.GetSection(nameof(ApplicationOptions.GraphQl)).Get<GraphQlOptions>();
        return services.AddGraphQLServer()
                .AddQueryType<RootQueryResolver>()
                .AddTypeExtension<ProjectsQueryResolver>()
                // .AddMutationType<RootMutationResolver>()
                // .AddAuthorization()
                // .AddDirectiveType<DeferDirectiveType>()
                // .AddProjectScalarTypes()
                // .AddProjectDirectives()
                // .AddProjectDataLoaders()
                // .AddProjectTypes()
                .AddProjections()
                .AddFiltering()
                .AddSorting()
                // .AddApolloTracing() // onDemand: add "GraphQl-tracing": 1 to http Header
                // .EnableRelaySupport()
                // .TrimTypes()
                // .ModifyOptions(options => options.UseXmlDocumentation = false)
                // .AddMaxComplexityRule(graphQlOptions.MaxAllowedComplexity)
                // .AddMaxExecutionDepthRule(graphQlOptions.MaxAllowedExecutionDepth)
                // .SetPagingOptions(graphQlOptions.Paging)
                // .SetRequestOptions(() => graphQlOptions.Request)
                .Services
            ;
    }
}