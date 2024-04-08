using GraphQLTemplate.Domain.Entities;

namespace GraphQLTemplate.Services.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetPartialName(string name);
    }
}
