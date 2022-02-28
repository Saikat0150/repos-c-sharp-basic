using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Matchcollection
{
    class Program
    {
        private static void showMatch(string text,string expr)
        {
            Console.WriteLine("The expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach(Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            string str = "make maze and manage to mesure it";
            Console.WriteLine("matching word that starts with s");
            showMatch(str, @"\bm\S*e\b");
            Console.ReadLine();
        }
    }
}
