using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ClassLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PC> pcList = new List<PC>()
            {
                new PC("Asus",Guid.NewGuid(),"White"),
                new PC("Acer", Guid.NewGuid(), "Black"),
                new PC("Philips", Guid.NewGuid(),"Black"),
                new PC("HP", Guid.NewGuid(), "Gray"),
            };

            if (File.Exists(@"D:\listSerial.txt"))
                Console.WriteLine("Файл уже существует!");

            using (FileStream stream = new FileStream(@"D:\listSerial.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, pcList);
            }

        }
    }
}
