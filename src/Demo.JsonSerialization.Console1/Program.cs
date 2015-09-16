
using System;
using System.Diagnostics;

using Newtonsoft.Json;

namespace Demo.JsonSerialization.Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            var type1Person = new Type1.Person
            {
                FirstName = "Todd",
                LastName = "Meinershagen",
                Address = new Type1.Address {Line1 = "1850 Countryside Dr", City = "Frisco", State = "TX", ZipCode = "75034"}
            };

            var json = JsonConvert.SerializeObject(type1Person);

            var type2Person = JsonConvert.DeserializeObject<Type2.Person>(json);

            Debug.Assert(type2Person.Address is Type2.Address);

            Console.WriteLine("It worked!");
            Console.ReadLine();
        }
    }
}
