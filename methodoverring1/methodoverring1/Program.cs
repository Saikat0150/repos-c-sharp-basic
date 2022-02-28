using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverring1
{
    class Override
    {
        public virtual void show()
        {
            Console.WriteLine("Baseclass Show");
        }
    }
    class override2 : Override
    {
        public override void show()
        {
            base.show(); //Calling base class method
            Console.WriteLine("Sub show");
    }
}
    class Program
    {
        static void Main(string[] args)
        {

            override2 over1 = new override2();
            over1.show();
            Console.ReadLine();
        }
    }

}
