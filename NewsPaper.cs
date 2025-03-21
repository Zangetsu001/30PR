using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class NewsPaper:PrintedProduct
    {
        private int circulation;
        private int numpages;
        private double costperpage;

        public int Circulation { get => circulation; set => circulation = value; }
        public int Numpages { get => numpages; set => numpages = value; }
        public double Costperpage { get => costperpage; set => costperpage = value; }
        public NewsPaper(string name, int circulation, int numpages, double costperpage) : base(name)
        {
            Circulation = circulation;
            Numpages = numpages;
            Costperpage = costperpage;
        }
        public override double Cost()
        {
            return Circulation * Numpages * Costperpage;
        }

    }
}
