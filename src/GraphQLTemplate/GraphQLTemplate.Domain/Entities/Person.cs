namespace GraphQLTemplate.Domain.Entities
{
    public abstract class Person(string name, string phone, string idNumber)
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; set; } = name;
        /// <summary>
        /// Phone number containing international code
        /// No validation happening here
        /// </summary>
        public string Phone { get; set; } = phone;
        /// <summary>
        /// IdNumber is related to any Identification number
        /// Example: Social Security Number, CPF
        /// </summary>
        public string IdNumber { get; set; } = idNumber;
    }
}
