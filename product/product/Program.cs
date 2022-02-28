using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    class Product
    {
        private double _height;
        public double height
        {
            get
            {
                return _height + 1;
            }
            set
            {
                if (value < 0)
                {
                    _height = 0;
                }
                else
                {
                    _height = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.height = 3;
            Console.Write(p.height);
            Console.Read();
        }
    }
}
