using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class PC
    {
        private string mark;
        private Guid id;
        private string color;

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public PC()
        {
            mark = "Asus";
            color = "Black";
        }

        public PC(string mark, Guid id, string color)
        {
            this.mark = mark;
            this.id = id;
            this.color = color;
        }

        public void TurnOn()
        {
            Console.WriteLine("Компьютер включен!");
        }

        public void TurnOff()
        {
            Console.WriteLine("Компьютер выключен!");
        }

    }
}
