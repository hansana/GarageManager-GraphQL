using GarageManager.GraphQL.Application.GraphQL;
using GraphQL;
using GraphQL.Server;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GarageManager.GraphQL.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(
                s.GetRequiredService));
            services.AddScoped<CustomerSchema>();

            services.AddGraphQL(o => { o.ExposeExceptions = true; })
                .AddGraphTypes(ServiceLifetime.Scoped);
        }
    }
}
