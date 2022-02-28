using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> n = new SortedList<string, string>();
            n.Add("1", "Sunil");
            n.Add("4", "Peter");
            n.Add("5", "jemes");
            n.Add("3", "Suresh");
            n.Add("2", "Ram");
            foreach(KeyValuePair<string,string> kv in n)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.Read();
        }
    }
}
