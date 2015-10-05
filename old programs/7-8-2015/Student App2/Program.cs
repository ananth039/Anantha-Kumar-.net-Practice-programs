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

            List<string> Student = new List<string>(3);

            //1st do..while loop begin
            do
            {
                GetDetails(Student, out Name, out phno, out course);

                Console.WriteLine("Do you wnat to continue? yes->y ,No->N");
                ask = Console.ReadLine();
                //ask the question continue or no

                if (ask == "y" || ask == "Y")
                {
                    Console.WriteLine("");
                    iscontinue = true;  //again repeat 1st do..while loop executing

                }

                else if (ask == "n" || ask == "N")
                {


                    // 2nd do..while loop begin
                    do
                    {
                        Console.WriteLine("");
                        Console.WriteLine("1.Display All students Details \n 2.search for student");
                        Console.WriteLine("Enter your choice");

                        try   //try block begin
                        {
                            choice = int.Parse(Console.ReadLine());
                            Console.WriteLine("");

                            if (choice == 1) //if choice is 1 display the user details
                            {

                                DisplayStudentDetails(ref iscontinue1, ref i, Student);

                                Console.WriteLine("");

                            }

                            else if (choice == 2)   //if choice is 2 search for student details
                            {
                                AddDetails(phno, Student);

                            } //end of else if condition

                        } // end of outer try block

                        catch (FormatException fe)
                        {
                            Console.WriteLine(fe.Message); //Exception message is displayed
                        }
                        catch (OverflowException fe)
                        {
                            Console.WriteLine(fe.Message); //Exception message is displayed
                        }

                    } while (iscontinue1); //end 2nd do..while loop


                }

                else
                {
                    Console.WriteLine("Invalid Option");
                    break;  // loop is stop and exit program
                }


            }

            while (iscontinue); //en of 1st do..while loop


        }

        private static void AddDetails(String phno, List<string> Student)
        {
            IDictionary<string, string> StudentDictionary = new Dictionary<string, string>(3);

            foreach (string s in Student)
            {
                //  StudentDictionary.Add(phno, s);

                StudentDictionary[phno] = s;

            }
            foreach (KeyValuePair<string, string> keyValuePair in StudentDictionary)
            {

                Console.WriteLine("{0}=>{1}", keyValuePair.Key, keyValuePair.Value);
            }


            SearchDetails(phno, StudentDictionary);
        }

        private static void DisplayStudentDetails(ref bool iscontinue1, ref int i, List<string> Student)
        {
            Console.Write("****Student Details******\n");

            foreach (string s in Student)
            {

                Console.WriteLine((i + 1) + " : " + s);
                i++;
                iscontinue1 = true;  //Repeat again 2nd do..while loop is executing
            }
        }

        private static void SearchDetails(String phno, IDictionary<string, string> StudentDictionary)
        {
            try
            {
                Console.WriteLine("");

                Console.WriteLine("Enter student phone number ");

                string id = Console.ReadLine();

                //find the student phno and compare and display particular student details

                if (StudentDictionary.ContainsKey(id))
                {
                    Console.Write("\n *****student details******\n");
                    Console.WriteLine("{0}=>{1}", id, StudentDictionary[phno]);

                }

                else // phone number is not maching
                {

                    Console.WriteLine("Invalid phone number");
                }
            } //end  of inner try block
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }

        private static void GetDetails(List<string> Student, out String Name, out String phno, out String course)
        {
            Console.WriteLine("Enter your Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number");
            phno = Console.ReadLine();
            Console.WriteLine("Enter your Course");
            course = Console.ReadLine();
            //student details are added to list
            Student.Add(Name + " ," + phno + ", " + course);
            //Student.Add("name :"+Name+", phno:"+phno+",course:"+course);
        }

    }

}


