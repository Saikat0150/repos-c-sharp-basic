using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string loc = "D:\\bInfo.txt";
                FileInfo file = new FileInfo(loc);
                file.Create();
                Console.WriteLine("File is created Successfully");
            }
            catch(IOException e)
            {
                Console.WriteLine("Something is going wrong." + e);
            }
            Console.Read();
        }
    }
}
