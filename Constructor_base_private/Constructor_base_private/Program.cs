using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_base_private
{
    class Insect
    {
        private int size;
        private string color;
        public Insect(int size,string color)
        {
            this.size = size;
            this.color = color;
        }
        public void Move()
        {
            Console.WriteLine("Insect move ->");
        }
        public void Attack()
        {
            Console.WriteLine("Insect Attack ->");
        }
    }
    class Wasp : Insect
    {
        public Wasp(int size,string color) : base(size, color)
        {

        }
        public void Move()
        {
            base.Move();
            Console.WriteLine("Wasp Fly");
        }
        public void Attack()
        {
            base.Attack();
            Console.WriteLine("Wasp Attack");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wasp w = new Wasp(5,"Red");
            w.Move();
            w.Attack();
            Console.Read();
        }
    }
}
