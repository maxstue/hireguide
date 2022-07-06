using HotChocolate.Types;

namespace hireguide.Application.Features.Projects;

[ExtendObjectType("RootQueryResolver")]
public class ProjectsQueryResolver
{
    public string GetHello() => "Hello world";
}