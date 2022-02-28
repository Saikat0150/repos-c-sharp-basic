using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    struct Books
    {
        public string title;
        public string authore;
        public string subject;
        public int book_id;
    };
    class Program
    {
        static void Main(string[] args)
        {
            Books book1;
            Books book2;
            book1.title = "C Programming";
            book1.authore = "Nila";
            book1.subject = "All about C programming";
            book1.book_id = 236521;

            book2.title = "Java Programming";
            book2.authore = "Raj";
            book2.subject = "Java Fundamentals";
            book2.book_id = 514953;

            Console.WriteLine("Details of first book: ");
            Console.WriteLine("Title: " + book1.title);
            Console.WriteLine("Authore: " + book1.authore);
            Console.WriteLine("Subject: " + book1.subject);
            Console.WriteLine("Book id: " + book1.book_id);

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Details of second book: ");
            Console.WriteLine("Title: " + book2.title);
            Console.WriteLine("Authore: " + book2.authore);
            Console.WriteLine("Subject: " + book2.subject);
            Console.WriteLine("Book id: " + book2.book_id);
            Console.ReadLine();
        }
    }
}
