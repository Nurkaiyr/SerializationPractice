using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
namespace DeserializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = new FileStream(@"D:\listSerial.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                List<PC> newPcList = formatter.Deserialize(stream) as List<PC>;
            }
        }
    }
}
