using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Notes
    {
        private String book;
        private string pen;
        public Notes()
        {
            book = "Akshara";
            pen = "cello";

        }
        public Notes(String book)
        {
            this.book = book;
            this.pen = "Renylods";
        }
        public Notes(string book,string pen)
        {
            this.book = book;
            this.pen = pen;
        }
        public void display()
        {
            Console.WriteLine("Book is {0} ", book);
            Console.WriteLine("Pen is {0}", pen);
        }

    }
}
