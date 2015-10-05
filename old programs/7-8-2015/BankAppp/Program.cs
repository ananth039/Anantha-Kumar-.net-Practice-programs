using StudentLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppp
{
    class Program
    {
        static List<String> StudentList = new List<string>(7);
        static void Main(string[] args)
        {

            string name,phno1,course1;
             Console.WriteLine("Enter your Name");
                name = Console.ReadLine();
                Console.WriteLine("Enter your Phone Number");
                phno1 = Console.ReadLine();
                Console.WriteLine("Enter your Course");
                course1 = Console.ReadLine();
                
            Student1 sd = new Student1();
            sd.Name = name;
            sd.phno = phno1;
            sd.course = course1;
            AddStudent(sd);


        }

        private static void AddStudent(Student1 sd)
        {
            StudentList.Add(sd);
        }
  
    }

}