using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Stream_Writter_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\B.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine("Hello C#");
            s.Close();
            f.Close();
            Console.Read();
        }
    }
}
