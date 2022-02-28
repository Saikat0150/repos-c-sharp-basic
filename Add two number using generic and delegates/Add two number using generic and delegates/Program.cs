using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_two_number_using_generic_and_delegates
{
    /*class Add<T>
    {
        
        dynamic n1,n2,sum;
        public void set(T n1, T n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public T getSum()
        {
            sum = n1 + n2;
            return sum;
        }
        public void Print()
        {
            Console.WriteLine("The Summation of " + n1 + " and " + n2 + " is: " + getSum());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Add<int> s1 = new Add<int>();
            s1.set(10,20);
            s1.Print();
            Console.Read();
        }
    }*/
    /*delegate string Calculate<T1, T2>(T1 a, T2 b);
    class Program
    {
        static string Addint(int a, int b)
        {
            return (a + b).ToString();
        }
        static string AddDouble(double a,double b)
        {
            return (a + b).ToString();
        }
        static void Main(string[] args)
        {

            Calculate<int, int> add = new Calculate<int, int>(Addint);
            Calculate<double, double> add1 = new Calculate<double, double>(AddDouble);
            Console.WriteLine(add.Invoke(15, 12));

            Console.WriteLine(add1.Invoke(6.77, 15.24));
            Console.Read();
        }
    }*/
    delegate T NumberChanger<T>(T n); 
    namespace GenericDelegateAppl
    {
        class TestDelegate
        {
            static int num = 10; 
            public static int AddNum(int p) 
            {
                num += p;
                return num;
            }
            public static int MultNum(int q)
            { 
                num *= q;
                return num; 
            }
            public static int getNum()
            { 
                return num;
            }
            static void Main(string[] args)
            { 
                //create delegate instances
                NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
                NumberChanger<int> nc2 = new NumberChanger<int>(MultNum); 
                //calling the methods using the delegate objects
                nc1(25);
                Console.WriteLine("Value of Num: {0}", getNum()); 
                nc2(5);
                Console.WriteLine("Value of Num: {0}", getNum());
                Console.ReadKey();
            }
        }
    }
}
