using GraphQLTemplate.Domain.Entities;
using HotChocolate.Types;

namespace GraphQLTemplate.Domain.GraphTypes
{
    public class CustomerType : ObjectType<Customer>
    {
        protected override void Configure(IObjectTypeDescriptor<Customer> descriptor)
        {
            descriptor
                .Field(f => f.IdNumber)
                .Type<StringType>();

            descriptor
                .Field(f => f.Name)
                .Type<StringType>();
            
            descriptor
                .Field(f => f.Cashback)
                .Type<DecimalType>();
            
            descriptor
                .Field(f => f.Phone)
                .Type<StringType>();
        }
    }
}
