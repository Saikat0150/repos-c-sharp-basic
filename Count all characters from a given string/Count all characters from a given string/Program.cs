using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_all_characters_from_a_given_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string c;
            int count = 0;
            Console.WriteLine("Enter the String: ");
            c = Console.ReadLine();
            foreach(char ch in c)
            {
                if(ch != ' ')
                {
                    count++;
                }
                
            }
            Console.WriteLine("The number of Characters in the given string is: " + count);
            Console.Read();
        }
    }
}
