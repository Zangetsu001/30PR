using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    abstract class PrintedProduct
    {
        private string name;
        public PrintedProduct() { }
        public PrintedProduct(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = (value != "") ? value : "soName";
            }
        }
        public abstract double Cost();

    
    }
}
