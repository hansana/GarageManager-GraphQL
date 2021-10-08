using GarageManager.GraphQL.DataModel.Contracts;
using GarageManager.GraphQL.DataModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageManager.GraphQL.DataModel.Repositories
{
    public class CustomerRepositoryAsync : GenericRepositoryAsync<Customer>, ICustomerRepositoryAsync
    {
        private readonly DbSet<Customer> _customers;

        public CustomerRepositoryAsync(GarageManagerDbContext dbContext) : base(dbContext)
        {
            _customers = dbContext.Set<Customer>();
        }
    }
}
