using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Russia("Петя"));
            people.Add(new Ukrainian("Петр"));
            people.Add(new English("Petro"));
            foreach(Person person in people)
            {
                person.SayHello();
            }
            Console.Read();
        }
    }
}
