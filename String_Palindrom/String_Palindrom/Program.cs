using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string s;

            Console.WriteLine("Enter the string: ");
            s = Console.ReadLine();
            int flag = 0;
            int j = s.Length-1;
            for(int i = 0; i < (s.Length) / 2; i++)
            {
                if (s[i] != s[j])
                {
                    flag += 1;
                    break;
                }
                else
                {
                    j--;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("The string is not Palindrom.");
            }
            else
            {
                Console.WriteLine("The string is palindrom..");
            }*/
            Console.WriteLine("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = n;
            int temp=0;
            while (n>0)
            {
                temp = (temp * 10) + (n % 10);
                n = n / 10;
            }
            if(n1==temp)
            {
                Console.WriteLine("The number is Palindrom.");
            }
            else
            {
                Console.WriteLine("The number is not palindrom..");
            }
            
            Console.ReadLine();
        }
    }
}
