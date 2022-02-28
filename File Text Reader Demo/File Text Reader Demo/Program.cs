using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Text_Reader_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using(TextReader tr = File.OpenText("D:\\B.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
            Console.Read();
        }
    }
}
