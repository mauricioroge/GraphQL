using GraphQLTemplate.Domain.GraphTypes;
using GraphQLTemplate.GraphQLQueries.Queries;
using HotChocolate.Types;

namespace GraphQLTemplate.GraphQLQueries.QueriesType
{
    public class CustomerQueryType: ObjectType<CustomerQuery>
    {
        protected override void Configure(IObjectTypeDescriptor<CustomerQuery> descriptor)
        {
            descriptor.Name(OperationTypeNames.Query);
            descriptor
                .Description("Get customers")
                .Field(f=> f.GetCustomers(default!,default!))
                .Type<ListType<CustomerType>>()
                .Argument("name", n => n.Type<NonNullType<StringType>>());
        }
    }
}
