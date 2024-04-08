namespace GraphQLTemplate.Domain.Entities
{
    public class Customer : Person
    {
        public decimal Cashback { get; set; }

        public Customer(string name, string phone, string idNumber) : base(name, phone, idNumber)
        {
            Cashback = 0m;
        }
    }
}
