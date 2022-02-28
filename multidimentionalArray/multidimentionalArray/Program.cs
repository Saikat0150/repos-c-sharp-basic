using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimentionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            Console.WriteLine("Enter the elements of the matrix: ");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is: ");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
