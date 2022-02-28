using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverloading
{
    public class Cal
    {
        
        public void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(double a,double b)
        {
            Console.WriteLine(a + b);
        }
        public void add(string a,string b)
        {
            Console.WriteLine(a + b);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cal c = new Cal();
            c.add(12, 23);
            c.add(40.23, 12.35);
            c.add("Saikat ", "Mondal");
            
            Console.Read();
        }
    }
}
