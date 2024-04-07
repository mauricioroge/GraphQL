using GraphQL.Types;
using System;
using Microsoft.Extensions.DependencyInjection;
using GraphQLTemplate.GraphQLQueries.Queries;
namespace GraphQLTemplate.GraphQLQueries.Schemas
{
    public class CustomersSchema : Schema
    {
        public CustomersSchema(IServiceProvider serviceProvider)
        : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<CustomersQuery>();
            Description = "Customers schema";
        }
    }
}
