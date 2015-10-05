using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, phno, course;
           string ask;
        
           int i=0;
             bool tocontinue=false;
             
            
            do
            {
               
                i+=i;
                String[] student = new string[5];
                Console.WriteLine("Enter your Name");
                Name = Console.ReadLine();
                Console.WriteLine("Enter your Phone Number");
                phno = Console.ReadLine();
                Console.WriteLine("Enter your Course");
                course = Console.ReadLine();

                student[i] = Name + " " + phno + " " + course;

                Console.WriteLine("Do you wnat to continue? yes->y ,No->N");
                  ask=Console.ReadLine();
                  if (ask == "y")
                  {

                      tocontinue = true;



                  }
                  else if (ask == "n" || ask == "N")
                  {
                      Console.WriteLine("1.Display All students Details \n 2.search for student");
                      Console.WriteLine("Enter your choice");
                      int choice = int.Parse(Console.ReadLine());
                      if (choice == 1)
                      {

                          for ( i = 0; i <5; i++)
                          {
                              Console.WriteLine(student[i]);

                          }


                      }

                  }
                  else
                  {
                      Console.WriteLine("Invalid Option");
                      break;
                  }

            }
            while (tocontinue);
          
       
    
        }

}       
  
}
