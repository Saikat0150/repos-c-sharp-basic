using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Writing_into_the_file
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string loc = "D:\\bInfo.txt";
                FileInfo file = new FileInfo(loc);
                StreamWriter sw = file.CreateText();
                sw.WriteLine("This text is written to the file by using streamwriter class");
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("Something is going wrong." + e);
            }
            Console.Read();
        }
    }
}
