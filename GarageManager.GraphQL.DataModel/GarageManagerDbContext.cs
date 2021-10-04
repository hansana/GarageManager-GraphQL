using GarageManager.GraphQL.DataModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace GarageManager.GraphQL.DataModel
{
    public class GarageManagerDbContext : DbContext
    {
        public GarageManagerDbContext(DbContextOptions<GarageManagerDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleAdmission> VehicleAdmissions { get; set; }
        public DbSet<CustomerVehicle> CustomerVehicles { get; set; }
    }
}
