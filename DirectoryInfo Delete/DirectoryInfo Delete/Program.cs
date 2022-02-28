using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryInfo_Delete
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
                    directory.Delete();
                    Console.WriteLine("Directory is deleted successfully..");
                    
                }
                else
                    Console.WriteLine("There is no such Directory..");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No directory is present.." + ex.ToString());
            }
            Console.Read();
        }
    }
}
