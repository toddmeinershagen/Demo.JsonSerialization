using Demo.JsonSerialization.Contracts;

namespace Demo.JsonSerialization.Console1.Type1
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAddress Address { get; set; }
    }
}
