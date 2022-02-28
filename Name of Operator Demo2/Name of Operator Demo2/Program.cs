using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_of_Operator_Demo2
{
    class NameOfExample
    {
        int[] arr = new int[5];
        public static void Main(string[] args)
        {
            NameOfExample ex = new NameOfExample();
            try
            {
                ex.show(ex.arr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                // Displaying method name that throws the exception
                Console.WriteLine("Method name is: " + nameof(ex.show));
                Console.Read();
            }
        }
        int show(int[] a)
        {
            a[6] = 12;
            return a[6];
        }
    }
 }
