using GarageManager.GraphQL.DataModel.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageManager.GraphQL.Application.GraphQL.Types
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field(t => t.FirstName);
        }
    }
}
