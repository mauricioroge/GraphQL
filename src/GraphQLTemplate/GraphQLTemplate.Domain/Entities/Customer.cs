namespace GraphQLTemplate.Domain.Entities
{
    public class Customer(string name, string phone, string idNumber) : Person(name, phone, idNumber)
    {
        public decimal Cashback { get; set; } = 0m;
    }
}
