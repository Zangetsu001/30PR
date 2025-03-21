using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            var magazine = new Magazine("Новые технологии", 89, 3.5);
            var newspaper = new NewsPaper("Новостная газета: Дневные новости", 32, 10, 0.2);

            Console.WriteLine($"Стоимость тиража журнала: '{magazine.Name}': {magazine.Cost()}");
            Console.WriteLine($"Стоимость тиража газеты: '{newspaper.Name}': {newspaper.Cost()}");

            Console.Read();
        }
    }
}
