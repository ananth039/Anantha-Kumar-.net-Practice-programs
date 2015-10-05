using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listofcoursesadded_using_delates
{
  
    public delegate void AddCourse(String courses);
   
  public  class CourseData
    {
        IList<string> Courseslist = new List<string>();  
         int i = 1;
        public string Coursenames
        {
            get;
            set;
        }
        public void AddCourse()
        {
           
            AddCourse courses = new AddCourse(Courseslist.Add);
            courses(Coursenames);

           
        }
   
        public void DisplayCourses()
        {
            AddCourse course1 = new AddCourse(Console.WriteLine);
            Console.ForegroundColor = ConsoleColor.Magenta;
            course1(" \n **List of courses** \n" );

            foreach (string c in Courseslist)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                course1("  " +i+ ". "+c);
                i++;
            }
            course1("");
        }
    }
}
