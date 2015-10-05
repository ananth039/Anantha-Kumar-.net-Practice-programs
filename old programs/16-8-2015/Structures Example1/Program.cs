using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_Example1
{
    struct Books
{
    public string Title;
    public string  author;
    public string subject;
    public string book_id;
}
    public class Programs
    {
        static void Main(string[] args)
        {
            Books book1;  /* Declare Book1 of type Book */
            Books book2;    /* Declare Book2 of type Book */

            /* book 1 specification */

            book1.Title = "Professional c# 5.0 and .NET 4.5.1";
            book1.author = "Christian Nagel,Glynn,Morgan skinner";
            book1.subject = "C# , Asp.net";
            book1.book_id = "101";

            /* book 2 specification */
            book2.Title = "Web Technologies";
            book2.author = "Black Book";
            book2.subject = "html, javascript, php, java, Servlets, jsp, xml and Ajax,asp.net";
            book2.book_id = "104";

            /* print Book1 info */
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("/* book 1 specification */");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Book1 Title: {0}", book1.Title);
            Console.WriteLine("Book1 author: {0}", book1.author);
            Console.WriteLine("Book1 subject: {0}", book1.subject);
            Console.WriteLine("Book1 book_id: {0} \n", book1.book_id);


            /* print Book2 info */
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("/* book 2 specification */");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Book2 Title: {0}", book2.Title);
            Console.WriteLine("Book2 author: {0}", book2.author);
            Console.WriteLine("Book2 subject: {0}", book2.subject);
            Console.WriteLine("Book2 book_id: {0} \n ", book2.book_id);

          
            Console.ReadKey();
            Console.Beep();
            
                

            
        }
    }

}
