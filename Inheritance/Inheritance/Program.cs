using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Country
    {
        protected void ShowCountry()
        {
            Console.WriteLine("This is India...");
        }
    }
    class State : Country
    {
        public void ShowState()
        {
            ShowCountry();
            Console.WriteLine("This is WestBengal...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            State s = new State();
            s.ShowState();
            Console.Read();
        }
    }
}
