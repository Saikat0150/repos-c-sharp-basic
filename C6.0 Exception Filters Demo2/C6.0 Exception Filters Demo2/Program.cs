using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6._0_Exception_Filters_Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new IndexOutOfRangeException("Array Exception Occured");
            }
            catch(Exception e)when(e.GetType().ToString()=="Array Exception Occured")
            {
                Console.WriteLine(e.Message);
                SomeOtherTask();
            }
            void SomeOtherTask()
            {
                Console.WriteLine("A new task is Executing..");
            }
            Console.ReadLine();
        }
    }
}
