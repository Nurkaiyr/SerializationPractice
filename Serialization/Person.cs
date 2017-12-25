using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public int Birthday { get; set; }
    }
}
