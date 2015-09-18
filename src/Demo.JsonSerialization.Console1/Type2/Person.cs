using Demo.JsonSerialization.Contracts;

using Newtonsoft.Json;

namespace Demo.JsonSerialization.Console1.Type2
{
    public class Person : IPerson
    {
        private Person()
        { }

        public Person(Address address)
        {
            Address = address;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IAddress Address { get; set; }
    }
}
