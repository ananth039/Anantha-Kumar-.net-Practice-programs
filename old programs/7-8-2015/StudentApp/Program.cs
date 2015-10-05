using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{

    class Program
    {
        static void Main(string[] args)
        {
            bool tocontinue = false;
            String Name;
            String phno;
            String course;
            List<string> Student = new List<string>();

            do
            {
                Console.WriteLine("Enter your Name");
                Name = Console.ReadLine();
                Console.WriteLine("Enter your Phone Number");
                phno = Console.ReadLine();
                Console.WriteLine("Enter your Course");
                course = Console.ReadLine();
                string stdetails = Name + " " + phno + " " + course;
                Student.Add(stdetails);

                Console.WriteLine("Do you wnat to continue? yes->y ,No->N");
                String ask = Console.ReadLine();

                if (ask == "y" || ask == "Y")
                {
                    Console.WriteLine("");
                    tocontinue = true;

                }

                else if (ask == "n" || ask == "N")
                {
                    bool tocontinue1 = false;
                    do
                    {
                        Console.WriteLine("");
                        Console.WriteLine("1.Display All students Details \n 2.search for student");
                        Console.WriteLine("Enter your choice");

                        int choice = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        if (choice == 1)
                        {
                            int i = 0;
                            foreach (string s in Student)
                            {

                                Console.WriteLine((i + 1) + ":" + s);
                                i++;
                                tocontinue1 = true;


                            }
                            Console.WriteLine("");
                        }

                        IDictionary<string, string> studentDictionary = new Dictionary<string, string>(3);
                        foreach (String s in Student)
                        {
                            studentDictionary.Add(phno,);

                        }
                        foreach (KeyValuePair<string, string> keyValuePair in studentDictionary)
                        {
                            Console.WriteLine("{0}=>{1}", keyValuePair.Key, keyValuePair.Value);
                        }
                        if (choice == 2)
                        {
                            Console.WriteLine("Enter student phone number ");

                            string id = Console.ReadLine();
                            if (studentDictionary.ContainsKey(id))
                            {
                                Console.WriteLine("{0}=>{1}", id, studentDictionary[phno]);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Key");
                            }


                        }
                        else
                        {
                            Console.WriteLine("Invalid Option");
                        }
                    } while (tocontinue1);

                }
            } while (tocontinue);

        }
                public  string ToString(string Name,string phno,String course)
                {
             return String.Format("Name:{0} phno:{1} course:{2}",Name,phno,course);
         
              }
    }
     

    }
