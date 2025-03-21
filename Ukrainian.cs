using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Ukrainian:Person
    {
        public Ukrainian(string name)
        {
            Name = name;
        }
        public override void SayHello()
        {
            Console.WriteLine($"{Name} сказав: Привiт!");
        }
    }
}
