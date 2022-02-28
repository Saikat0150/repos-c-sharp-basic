using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileRead_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\B.txt", FileMode.OpenOrCreate);
            
            //Reading file
            int i = 0;
            while ((i = f.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f.Close();
            Console.Read();
        }
    }
}
