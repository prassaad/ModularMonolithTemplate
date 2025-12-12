using System.Reflection;

namespace Modules.Common.Tests.Architecture;

internal static class ModuleAssemblies
{
    // Users module assemblies
    internal static readonly Assembly UsersDomainAssembly = Users.Domain.AssemblyReference.Assembly;
    internal static readonly Assembly UsersFeaturesAssembly = Users.Features.AssemblyReference.Assembly;
    internal static readonly Assembly UsersInfrastructureAssembly = Users.Infrastructure.AssemblyReference.Assembly;

}
