using Demo.JsonSerialization.Contracts;

using Newtonsoft.Json;

namespace Demo.JsonSerialization.Console1.Type3
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [JsonConverter(typeof(ConcreteTypeConverter<Address>))]
        public IAddress Address { get; set; }
    }
}
