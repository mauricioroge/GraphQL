using GraphQL.Types;
using GraphQLTemplate.Domain.Entities;

namespace GraphQLTemplate.Domain.GraphTypes
{
    public class StoreType : ObjectGraphType<Store>
    {
        public StoreType()
        {
            Field(x => x.Name)
                .Description("The Store's Name");
            Field(x => x.Address)
                .Description("The Store's Address");
            Field(x => x.Zipcode)
                .Description("The Store's Zipcode");
        }
    }
}
