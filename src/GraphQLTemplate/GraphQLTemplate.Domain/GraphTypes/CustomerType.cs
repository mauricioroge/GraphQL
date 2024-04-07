using GraphQL.Types;
using GraphQLTemplate.Domain.Entities;

namespace GraphQLTemplate.Domain.GraphTypes
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field(x => x.IdNumber)
                .Description("IdNumber is related to any Identification number\nExample: Social Security Number(USA), CPF(BR)");
            Field(x => x.Name)
                .Description("The customers name");
            Field(x => x.Cashback)
                .Description("The cashback amount from customer");
            Field(x => x.Phone)
                .Description("The customers phone");
        }
    }
}
