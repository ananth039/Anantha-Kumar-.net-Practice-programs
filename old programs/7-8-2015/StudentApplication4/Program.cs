using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication4
{
    class Program
    {
        List<string> Student = new List<string>();
       
        static void Main(string[] args)
        {
            bool tocontinue = false;
            String Name;
            String phno;
            String course;
           
            Console.WriteLine("Enter your Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number");
            phno = Console.ReadLine();
            Console.WriteLine("Enter your Course");
            course = Console.ReadLine();

            StudentLibrary.Student1 s = new StudentLibrary.Student1();
            s.Name = Name;
            s.phno = phno;
            s.course = course;
            StudentLibrary.Student1.Add(s);
           
         

        }
    }
}
