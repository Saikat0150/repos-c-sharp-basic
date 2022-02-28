using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_vowel
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter the string: ");
            string s = Console.ReadLine();
            foreach(char i in s)
            {
                if (i == 'a' || i == 'A' || i == 'E' || i == 'e' || i == 'I' || i == 'i' || i == 'O' || i == 'o' || i == 'U' || i == 'u')
                {
                    count++;                }
            }
            Console.WriteLine("The number of vowels in the string: " + count);
            Console.ReadLine();
        }
    }
}
