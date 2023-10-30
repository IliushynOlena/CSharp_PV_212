using System.Text.Json;
using System.Xml.Serialization;

namespace _21_XML_JsonSerializer
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        int _identNumber;
        [NonSerialized]
        const string Planet = "Earth";
        public Person()
        {

        }
        public Person(int number)
        {
            _identNumber = number;
        }
        public override string ToString()
        {
            return $"Name : {Name}, Age: {Age}, Identification number : {_identNumber}, Planet: {Planet}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
              new Person(123654){ Name="Jack", Age = 15},
              new Person(123654){ Name="Tom", Age = 12},
              new Person(123654){ Name="Bill", Age = 35},
              new Person(123654){ Name="John", Age = 47}
            };

            try
            {
                string filename = "Person.json";

                string jsonString = JsonSerializer.Serialize(persons);
                File.WriteAllText(filename, jsonString);

                //Deserialize
                jsonString = File.ReadAllText(filename);
                List<Person> list = JsonSerializer.Deserialize<List<Person>>(jsonString)!;
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            /*

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));

            try
            {
                //using (Stream stream = File.Create("Person.xml"))
                //{
                //    xmlSerializer.Serialize(stream, persons);
                //}
                //Console.WriteLine("XmlSerializer is OK!!!!");

                List<Person> newList = null;

                using (Stream stream = File.OpenRead("Person.xml"))
                {
                    newList = (List<Person>)xmlSerializer.Deserialize(stream);
                }
                foreach (var item in newList)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            */
        }
    }
}