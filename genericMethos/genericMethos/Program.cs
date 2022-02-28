using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericMethos
{
    class Sample
    {
        public void ReverseAndPrint<T>(T[] arr)
        {
            Array.Reverse(arr);
            foreach(T item in arr)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = { 3, 8, 9, 5, 7 };
            string[] stringarray = { "Oli", "Moli", "Joli", "Koli", "Holi" };
            double[] doublearray = { 10.55, 18.00, 54.68 };
            Sample s = new Sample();
            s.ReverseAndPrint<int>(intarray);
            s.ReverseAndPrint<string>(stringarray);
            s.ReverseAndPrint<double>(doublearray);
            Console.Read();
        }
    }
}
