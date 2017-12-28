using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            ReadCsv(person);
            SerializeToJson(person);
        }

        private static void SerializeToJson(Person person)
        {
            using (FileStream stream1 = new FileStream(@"C:\name_of_directory\name1.json", FileMode.OpenOrCreate))
            {
               // JsonSerializer serializer = new JsonSerializer();
                //serializer.Serialize(, person);
                var jsonserilizer = JsonConvert.SerializeObject(person);
            }
        }

        private static void ReadCsv(Person person)
        {
            using (FileStream stream = new FileStream(@"C:\name_of_directory\name.csv", FileMode.OpenOrCreate))
            {
                SoapFormatter formatter = new SoapFormatter();
                formatter.Serialize(stream, person);
            }
        }
    }
}
