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
            //№1
            //var magazine = new Magazine("Новые технологии", 89, 3.5);
            //var newspaper = new NewsPaper("Новостная газета: Дневные новости", 32, 10, 0.2);

            //Console.WriteLine($"Стоимость тиража журнала: '{magazine.Name}': {magazine.Cost()}");
            //Console.WriteLine($"Стоимость тиража газеты: '{newspaper.Name}': {newspaper.Cost()}");

            //№2
            //List<PrintedProduct> printeds = new List<PrintedProduct>();
            //printeds.Add(new Magazine("Информационные технологии и системное ПО", 200, 4.8));
            //printeds.Add(new NewsPaper("Пайтон для чайников", 14, 350, 3.6));
            //foreach(PrintedProduct p in printeds)
            //{
            //    p.Cost();
            //    Console.WriteLine("Стоимость тиража: " + p.Cost() + " руб.");
            //}

            //№3
            List<PrintedProduct> printeds = new List<PrintedProduct>();
            bool flag = true;
            do
            {
                Console.Write("Введите название печатной продукции: ");
                string metka = Console.ReadLine();
                switch (metka)
                {
                    case "пайтон для чайников": case "Пайтон для чайников":
                        {
                            printeds.Add(Magazine.Enter());
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Нет такой печатной продукции");
                            break;
                        }
                }
                foreach (PrintedProduct p in printeds)
                {
                    p.Print();

                }
            }
            while (flag);
            Console.Read();
        }
    }
}
