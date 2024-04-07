using GraphQL;
using GraphQL.Types;
using GraphQLTemplate.Domain.GraphTypes;
using GraphQLTemplate.Services.Interfaces;

namespace GraphQLTemplate.GraphQLQueries.Queries
{
    public class CustomersQuery: ObjectGraphType
    {
        public CustomersQuery(ICustomerService customerService)
        {
            Name = "Query";
            Field<CustomerType>("Customer")
                .Argument<StringGraphType>("name", "customers name")
                .Resolve(context => customerService.Get(context.GetArgument<string>("name")));

        }
    }
}
