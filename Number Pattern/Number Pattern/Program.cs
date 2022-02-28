using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int i, j, k, l;
                Console.Write("Enter the Range: ");
                int n = Convert.ToInt32(Console.ReadLine());
                //int c = 1;
                for (i = 0; i < n; i++)
                {
                    for (j = n - 1; j >= i; j--)
                    {
                        Console.Write(" ");

                    }
                    for (k = 0; k <= i; k++)
                    {
                        //Console.Write(c);
                        //c++;
                        Console.Write(k+1);
                    }
                    //c--;
                    //for (int l = 0; l < i; l++)
                    //{
                    //    Console.Write(--c);
                    //}
                    for(l = k - 1; l > 0; l--)
                    {
                        Console.Write(l);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
