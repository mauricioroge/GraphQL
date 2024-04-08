using GraphQLTemplate.Domain.Entities;
using GraphQLTemplate.Services.Interfaces;

namespace GraphQLTemplate.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> listCustomers = new() {
            new Customer("Kau", "5541999999999","012.345.678-12"),
            new Customer("Mau", "5541999988899","012.345.678-12"),
            new Customer("Cezar", "5577999999999","012.345.678-12"),
            new Customer("Teste", "141999999999","012.345.678-12"),
            new Customer("Fafnyr", "3341999999999","012.345.678-12"),
            new Customer("Leko", "5587999999999","012.345.678-12"),
            new Customer("Abraao", "8890999999999","012.345.678-12"),
            new Customer("Sheila", "3321999999999","012.345.678-12"),
            new Customer("Kest", "5541915679999","012.345.678-12"),
            new Customer("Ato", "1268999999999","012.345.678-12"),
            new Customer("Eto", "1511999999999","012.345.678-12")
        };
        public IEnumerable<Customer> GetPartialName(string name)
        {
            return listCustomers.Where(x=> x.Name.Contains(name));
        }
    }
}
