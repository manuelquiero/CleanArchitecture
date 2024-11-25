using CleanArchitecture.Application;
using CleanArchitecture.Infrastracture;

namespace CleanArchitecture
{
    public static class DependencyInjection
    {
        public static IServiceCollection CleanArchitectureDI(this IServiceCollection service)
        {
            service.ApplicationDI().InfrastructureDI();
            return service;
        }
    }
}
