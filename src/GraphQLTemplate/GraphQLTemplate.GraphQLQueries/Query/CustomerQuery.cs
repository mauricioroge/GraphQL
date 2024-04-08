using GraphQLTemplate.Domain.Entities;
using GraphQLTemplate.Services.Interfaces;
using HotChocolate;
using System.Collections.Generic;

namespace GraphQLTemplate.GraphQLQueries.Queries
{
    public class CustomerQuery
    {
        public IEnumerable<Customer> GetCustomers(string name, [Service] ICustomerService customerService )
        {
            return customerService.GetPartialName(name);
        }
    }
}
