using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> MyMessage = new List<string>();
            MyMessage.Add("Good Morning");
            MyMessage.Add("Good Afternoon");
            MyMessage.Add("Good Evening");
            MyMessage.Add("Good Night");
            Console.WriteLine(MyMessage.Count + "message found");
            foreach(string s in MyMessage)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}
