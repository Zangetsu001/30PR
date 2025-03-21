using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Magazine:PrintedProduct
    {
        private int circulation;
        private double price;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Magazine() { }
        public Magazine(string name, int circulation, double price):base(name)
        {
            Circulation = circulation;
            Price = price;
        }

        public int Circulation { get => circulation; set => circulation = value; }
        public double Price { get => price; set => price = value; }

        public override double Cost()
        {
            return Circulation * Price;
        }
    }
}
