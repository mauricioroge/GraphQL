using GraphQLTemplate.Domain.Entities;
using HotChocolate.Types;

namespace GraphQLTemplate.Domain.GraphTypes
{
    public class StoreType : ObjectType<Store>
    {
        public StoreType(IObjectTypeDescriptor<Store> descriptor)
        {
            descriptor
                .Field(f => f.Address)
                .Type<StringType>();

            descriptor
                .Field(f => f.Name)
                .Type<StringType>();

            descriptor
                .Field(f => f.Zipcode)
                .Type<StringType>();
        }
    }
}
