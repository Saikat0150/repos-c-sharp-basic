using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add("Hai");
            a.Add("How are you");
            a.Add(1000);
            a.Add(true);
            a.Add(DateTime.Now);
            Console.WriteLine(a.Count + " values are found");
            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.Read();
        }
    }
}
