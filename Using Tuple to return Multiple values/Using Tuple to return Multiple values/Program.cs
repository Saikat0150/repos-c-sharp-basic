using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Tuple_to_return_Multiple_values
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, email) = Show();
            Console.WriteLine("Name is: " + name + ". Email is: " + email);
            Console.Read();
        }
        static (string name,string email) Show()
        {
            return ("ram", "ram@gmail.com");
        }
    }
}
