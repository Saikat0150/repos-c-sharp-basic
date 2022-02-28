using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 4, 6, 12, 2, 10 };
            Console.WriteLine("Length is: " + arr.Length);
            Console.WriteLine("Rank is: " + arr.Rank);
            Console.WriteLine("Array before any change: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            //////////////////////////////////////////
            int[] arr1 = new int[arr.Length];
            arr.CopyTo(arr1, 0);
            Console.WriteLine("Array after copying:");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------------");
            //////////////////////////////////////////////////////////
            Array.Sort(arr1);
            Console.WriteLine("Array after Sorting: ");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            ///////////////////////////////////////////
            Array.Reverse(arr1);
            Console.WriteLine("Array after Reversing: ");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            /////////////////////////////////////////////

            string[] arrs = { "saikat", "OLi", "Anshu", "Deep", "Ayush" };
            Console.WriteLine("Length is: " + arrs.Length);
            Console.WriteLine("Rank is: " + arrs.Rank);
            Console.WriteLine("String array before any change: ");
            for (int i = 0; i < arrs.Length; i++)
            {
                Console.Write(arrs[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            ///////////////////////////////////////////
            string[] arrs1 = new string[arrs.Length];
            arrs.CopyTo(arrs1, 0);

            Console.WriteLine("Array after copying:");
            for (int i = 0; i < arrs1.Length; i++)
            {
                Console.Write(arrs1[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            ///////////////////////////////////////////////
            Array.Sort(arrs1);
            Console.WriteLine("Array after Sorting: ");
            for (int i = 0; i < arrs1.Length; i++)
            {
                Console.Write(arrs1[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            ////////////////////////////////////////////////////////
            Array.Reverse(arrs1);
            Console.WriteLine("Array after Reversing: ");
            for (int i = 0; i < arrs1.Length; i++)
            {
                Console.Write(arrs1[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            /////////////////////////////////////////////////////

            int[,] arr2d = new int[,] { { 10, 20, 11 }, { 15, 14, 18 }, { 80, 81, 30 } };
            Console.WriteLine("Length is: " + arr2d.Length);
            Console.WriteLine("Rank is: " + arr2d.Rank);
            Console.WriteLine("-------------------------------------------------------");
            ///////////////////////////////////////////////////
            Console.WriteLine("The 2d Array is: ");
            int c = 0;
            foreach(int i in arr2d)
            {
                Console.Write(i + "\t");
                c++;
                if(c==3)
                {
                    Console.WriteLine();
                    c = 0;
                }

            }


            Console.WriteLine("....End of the program....");
            Console.Read();
        }
    }
}
