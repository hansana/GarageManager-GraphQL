using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageManager.GraphQL.Application.GraphQL
{
    public class CustomerSchema : Schema
    {
        public CustomerSchema(IDependencyResolver resolver): base(resolver)
        {
            Query = resolver.Resolve<CustomerQuery>();
        }
    }
}
