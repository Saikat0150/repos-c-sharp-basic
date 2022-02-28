using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Stream_Reader_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\B.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            //for single line
            //string line = s.ReadLine();
            //Console.WriteLine(line);

            //for multiple line
            string line = "";
            while ((line = s.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            s.Close();
            f.Close();
            Console.Read();
        }
    }
}
