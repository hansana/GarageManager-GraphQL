using GarageManager.GraphQL.Application.GraphQL.Types;
using GarageManager.GraphQL.DataModel.Contracts;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageManager.GraphQL.Application.GraphQL
{
    public class CustomerQuery : ObjectGraphType
    {
        private readonly ICustomerRepositoryAsync _customerRepositoryAsync;

        public CustomerQuery(ICustomerRepositoryAsync customerRepositoryAsync)
        {
            _customerRepositoryAsync = customerRepositoryAsync;
            Field<ListGraphType<CustomerType>>(
                "customers",
                resolve: context => _customerRepositoryAsync.GetAllAsync()
                );
        }
    }
}
