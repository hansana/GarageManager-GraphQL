using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GarageManager.GraphQL.DataModel.Contracts;
using GarageManager.GraphQL.DataModel.Repositories;

namespace GarageManager.GraphQL.DataModel
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<GarageManagerDbContext>(options =>
                    options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<GarageManagerDbContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(GarageManagerDbContext).Assembly.FullName)
                        ));
            }

            #region Repositories
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            /**services.AddTransient<IVehicleRepositoryAsync, VehicleRepositoryAsync>();
            services.AddTransient<ICustomerRepositoryAsync, CustomerRepositoryAsync>();
            services.AddTransient<IVehicleAdmisionRepositoryAsync, VehicleAdmisionRepositoryAsync>();
            services.AddTransient<IUserRepositoryAsync, UserRepositoryAsync>();
            services.AddTransient<ICustomerVehicleRepositoryAsync, CustomerVehicleRepositoryAsync>();*/
            #endregion
        }
    }
}
