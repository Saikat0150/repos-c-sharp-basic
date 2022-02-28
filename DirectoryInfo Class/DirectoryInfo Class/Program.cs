using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryInfo_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"D:\Directory");
            try
            {
                if (directory.Exists)
                {
                    Console.WriteLine("Directory already exist..");
                    return;
                }
                directory.Create();
                Console.WriteLine("The directory is created successfully..");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Directory is not created.." + ex.ToString());
            }
            Console.Read();        
        }
    }
}
