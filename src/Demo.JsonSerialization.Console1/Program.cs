
using System;
using System.Diagnostics;

using Demo.JsonSerialization.Contracts;

using Newtonsoft.Json;

namespace Demo.JsonSerialization.Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Type1.Person
            {
                FirstName = "Todd",
                LastName = "Meinershagen",
                Address = new Type1.Address {Line1 = "1850 Countryside Dr", City = "Frisco", State = "TX", ZipCode = "75034"}
            };

            var json = JsonConvert.SerializeObject(person, Formatting.Indented);
            
            TestConstructorMethod(json);
            TestPropertyMethod(json);
            TestSerializerSettingsMethod(json);
            TestSerializerSettingsOverrideMethod(json);

            Console.ReadLine();
        }

        private static void TestConstructorMethod(string json)
        {
            var type2Person = JsonConvert.DeserializeObject<Type2.Person>(json);
            Debug.Assert(type2Person.Address is Type2.Address);
            Console.WriteLine("Constructor Method - Worked!");
        }

        private static void TestPropertyMethod(string json)
        {
            var type3Person = JsonConvert.DeserializeObject<Type3.Person>(json);
            Debug.Assert(type3Person.Address is Type3.Address);
            Console.WriteLine("Property Method - Worked");
        }

        private static void TestSerializerSettingsMethod(string json)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new Type1.ConcreteTypeConverter<IAddress, Type1.Address>());
            var type1Person = JsonConvert.DeserializeObject<Type1.Person>(json, settings);
            Debug.Assert(type1Person.Address is Type1.Address);
            Console.WriteLine("Serializer Settings Method - Worked!");
        }

        private static void TestSerializerSettingsOverrideMethod(string json)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new Type1.ConcreteTypeConverter<IAddress, Type1.Address>());
            settings.ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor;
            var type2Person = JsonConvert.DeserializeObject<Type2.Person>(json, settings);
            Debug.Assert(type2Person.Address is Type1.Address);
            Console.WriteLine("Serializer Settings Override Method - Worked!");
        }
    }
}
