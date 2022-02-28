using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_initializer_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> di = new Dictionary<int, string>()
            {
                [1] = "Ram",
                [2] = "Sita",
                [3] = "Laxman"
            };
            foreach(KeyValuePair<int,string> kv in di)
            {
                Console.WriteLine("{Key= " + kv.Key + " Value= " + kv.Value + "}");
            }
            Console.Read();
        }
    }
}
