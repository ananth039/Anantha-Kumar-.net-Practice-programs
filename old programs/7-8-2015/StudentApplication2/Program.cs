using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentApplication2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool iscontinue = false;
            bool iscontinue1 = false;
           
            String Name;
            String phno;
            String course;
            String ask;
            int choice;
            int i = 0;

           List<string> studentList = new List<string>();

            //begining of outer do..while loop
           IDictionary<string, string> StudentDictionary = new Dictionary<string, string>(3);
              
            do 
               {
                  Console.WriteLine("Enter your Name");
                  Name = Console.ReadLine();
                  Console.WriteLine("Enter your Phone Number");
                  phno = Console.ReadLine();
                  Console.WriteLine("Enter your Course");
                  course = Console.ReadLine();

                  //student details are added to list
                  string studentDetail = Name + " ," + phno + ", " + course;
                  studentList.Add(studentDetail);
                 

                  
                      //  StudentDictionary.Add(phno, s);

                      StudentDictionary[phno] = studentDetail;

                  

             
               
                  Console.WriteLine("Do you wnat to continue? yes->y ,No->N");
                  ask = Console.ReadLine();
                 //ask the question continue or no

             if (ask == "y" || ask == "Y")
                 {
                     Console.WriteLine("");
                     iscontinue = true;  //again repeat 1st do..while loop executing

                 } //end of if condition

                 else if (ask == "n" || ask == "N")   //outer else if condition begin
                 {
                 
                     // inner do..while loop begin

                     do 
                     {
                         Console.WriteLine("");
                         Console.WriteLine("1.Display All students Details \n 2.search for student \n 3.exit");
                         Console.WriteLine("Enter your choice");

                         try   // outer try block begin
                         {
                             choice = int.Parse(Console.ReadLine());
                             Console.WriteLine("");

                             if (choice == 1) // if choice is 1 display the user details
                             {
                              
                                 Console.Write("****Student Details******\n");

                                 foreach (string s in studentList)
                                 {

                                     Console.WriteLine((i + 1) + " : " + s);
                                     i++;
                                     iscontinue1 = true;  //Repeat again 2nd do..while loop is executing
                                  }

                                  Console.WriteLine("");

                              }  //end of if condition


                             else if (choice == 2)    //if choice is 2 search for student details
                             {

                                 
                                 //foreach (KeyValuePair<string, string> keyValuePair in StudentDictionary)
                                 //{

                                 //    Console.WriteLine("{0}=>{1}", keyValuePair.Key, keyValuePair.Value);
                                 //}

                                  try   //inner try block begin
                                   {
                                       Console.WriteLine("");
                                       Console.WriteLine("Enter student phone number ");

                                        string id = Console.ReadLine();

                                        //find the student phno and compare and display particular student details

                                        if (StudentDictionary.ContainsKey(id))
                                         {
                                            Console.Write("\n *****student details******\n");
                                            Console.WriteLine("{0}=>{1}", id, StudentDictionary[id]);

                                          }

                                        else // phone number is not maching in List
                                          {

                                             Console.WriteLine("Invalid phone number");
                                          }

                                    }   //end  of inner try block

                                  catch (ArgumentException ae)
                                    {

                                      Console.WriteLine(ae.Message);
                                      iscontinue1 = true;
                                     }


                            } //end of inner else if condition

                           else if (choice == 3)      //if choice is 3 stop program and exit in to loop
                             {

                                 break;
                              
                             }
                            
                           else
                             {
                                 Console.WriteLine("Invalid Option");
                                 break;
                                 // loop is stop and exit program
                                   
                             }
                        

                      } // end of outer try block

                       catch (FormatException fe) 
                        {
                            Console.WriteLine(fe.Message); // Format Exception message is displayed
                            iscontinue1 = true;
                        }
                        catch (OverflowException fe)
                        {
                            Console.WriteLine(fe.Message); //Format message is displayed
                            iscontinue1 = true;
                         }

                 } while (iscontinue1); //end of inner do..while loop

             }  //end of outer else if condition 

                 else
                 {
                     Console.WriteLine("Ivalid Option");
                 }


              
                 
        } while (iscontinue); // end of outer do..while loop
          
          

      }
   
      
   }
        

 }




