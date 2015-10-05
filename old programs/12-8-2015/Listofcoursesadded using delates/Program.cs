using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listofcoursesadded_using_delates
{
    
    class Program
    {

        static void Main(string[] args)
        {
             CourseData cd = new CourseData();
                string name,ask;
            bool isContinue=false;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please Enter Course Name");
                name = Console.ReadLine();
                cd.Coursenames = name;
                cd.AddCourse();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you want Add new Course yes-->Y No-->N");
                ask = Console.ReadLine();
                if (ask == "y" || ask == "Y")
                {
                    isContinue = true;
                }
                else if (ask == "n" || ask == "N")
                {
                    cd.DisplayCourses();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Option");
                    Console.Beep();
                    break;
                }

            } while (isContinue);

              Console.ReadLine();
        }
    }
}
