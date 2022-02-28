using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reading_Data_from_file_using_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string loc = "D:\\bInfo.txt";
                FileInfo file = new FileInfo(loc);
                StreamReader sr = file.OpenText();
                //one Way to print full file
                /*string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();*/

                //another way to print full file
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (IOException e)
            {
                Console.WriteLine("Something is going wrong." + e);
            }
            Console.Read();
        }
    }
}
