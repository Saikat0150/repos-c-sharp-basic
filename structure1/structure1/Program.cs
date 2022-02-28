using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure1
{
    struct Books
    {
        public string title;
        public string authore;
        public string subject;
        public int book_id;

        public void setData(string t, string a,string s,int id)
        {
            title = t;
            authore = a;
            subject = s;
            book_id=id;
        }

        public void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Authore: " + authore);
            Console.WriteLine("Subject: " + subject);
            Console.WriteLine("Book id: " + book_id);
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            Books book1=new Books();
            Books book2=new Books();
            book1.setData("C Programming", "Nila", "All about C programming", 236521);

            book2.setData("Java Programming", "Raj", "Java Fundamentals", 514953);

            Console.WriteLine("Details of first book: ");
            book1.display();

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Details of second book: ");
            book2.display();
            Console.ReadLine();
        }
    }
}
