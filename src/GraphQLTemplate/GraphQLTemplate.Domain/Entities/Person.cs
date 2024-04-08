namespace GraphQLTemplate.Domain.Entities
{
    public abstract class Person
    {
        protected Person(string name, string phone, string idNumber)
        {
            Name = name;
            Phone = phone;
            IdNumber = idNumber;
        }

        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; set; }
        /// <summary>
        /// Phone number containing international code
        /// No validation happening here
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// IdNumber is related to any Identification number
        /// Example: Social Security Number, CPF
        /// </summary>
        public string IdNumber { get; set; }
    }
}
