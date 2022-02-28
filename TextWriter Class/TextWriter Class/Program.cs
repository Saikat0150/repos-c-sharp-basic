using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextWriter_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("D:\\B.txt"))
            {
                writer.WriteLine("Hello C#");
                writer.WriteLine("C# File Handling");
            }
            Console.WriteLine("Data Written Successfully");
            Console.Read();

        }
    }
}
