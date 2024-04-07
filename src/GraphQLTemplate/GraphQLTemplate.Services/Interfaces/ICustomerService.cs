using GraphQLTemplate.Domain.Entities;

namespace GraphQLTemplate.Services.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> Get(string name);
    }
}
