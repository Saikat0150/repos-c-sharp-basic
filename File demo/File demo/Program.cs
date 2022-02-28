using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWrite_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\B.txt", FileMode.OpenOrCreate);
            //For Writing the File
            for(int j = 0; j <= 90; j++)
            {
                f.WriteByte((byte)j);
            }
            
            f.Close();
            Console.Read();
        }
    }
}
