using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Binary_Writer_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "D:\\B.txt";
            using(BinaryWriter writer=new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("This is String data");
                writer.Write(true);
            }
            Console.WriteLine("Data is written successfully");
            Console.Read();
        }
    }
}
