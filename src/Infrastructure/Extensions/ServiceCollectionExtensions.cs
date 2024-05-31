using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;

namespace Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAllImplementationsOfInterface(this IServiceCollection services, Type interfaceType, Assembly assembly)
        {
            var implementations = assembly.GetTypes()
                .Where(t => t.GetInterfaces().Contains(interfaceType) && !t.IsAbstract && !t.IsInterface);

            foreach (var implementation in implementations)
            {
                services.AddTransient(interfaceType, implementation);
            }
        }
    }
}
