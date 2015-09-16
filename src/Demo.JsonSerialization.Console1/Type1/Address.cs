using Demo.JsonSerialization.Contracts;

namespace Demo.JsonSerialization.Console1.Type1
{
    public class Address : IAddress
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}