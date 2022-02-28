using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClass
{
    static class Square
    {
        public static int side;
        public static int getArea()
        {
            return side * side;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of one side of the square: ");
            Square.side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The are of the square is: " + Square.getArea());
            Console.Read();
        }
    }
}
