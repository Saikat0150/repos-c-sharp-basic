using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of row: ");
            int n = Convert.ToInt32(Console.ReadLine());
            /*for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            /*int i, j, k;
            for(i = 0; i < n; i++)
            {
                for(j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for(k = i; k >= 0; k--)
                {
                    Console.Write("*");
                }
                for (int l = 0; l < i; l++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }*/

            /*for (i = 0; i < n; i++)
            {
                for (j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = i; k >= 0; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }*/

            /*for (int i = n; i > 0; i--)
            {
                for (int k = 0; k < n-i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

            /*for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }*/

            /*int c = 1;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(c+" ");
                    c += 2;
                }
                Console.WriteLine();
            }*/

            /*for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }*/

            for (int i = n; i > 0; i--)
            {
                int c = i;
                for (int j = i; j > 0; j--)
                {
                    Console.Write(c+" ");
                    c++;
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
