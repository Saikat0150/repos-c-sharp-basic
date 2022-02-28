using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace_Date_Time
{
    interface DateAndTransectionAmount
    {
        string TransectionId();
        string Date();
        double Amount();
    }
    class History : DateAndTransectionAmount
    {
        string id;
        int day, month, year;
        double m;
        public History(string id, int day, int month, int year, double m)
        {
            this.id = id;
            this.day = day;
            this.month = month;
            this.year = year;
            this.m = m;
        }
        public string TransectionId()
        {
            return id;
        }
        public string Date()
        {
            return day + "/" + month + "/" + year;
        }
        public double Amount()
        {
            return m;
        }
        public void Display()
        {
            Console.WriteLine("Transaction: " + TransectionId());
            Console.WriteLine("Date: " + Date());
            Console.WriteLine("Amount: " + Amount());
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            History h = new History("001",08,10,2012,78900);
            Console.WriteLine("The first transaction: ");
            h.Display();
            
            
            History h1 = new History("002", 09, 10, 2012, 451900);
            Console.WriteLine("Another transaction: ");
            h1.Display();

            Console.Read();
        }
    }
}
