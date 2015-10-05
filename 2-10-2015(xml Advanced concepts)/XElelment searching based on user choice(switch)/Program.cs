using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XElelment_searching_based_on_user_choice_switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            int Userchoice;
            string name,roomtype,fee,phonenumber,id;

            XElement RootElement=XElement.Load("HostelInformation.xml");

            Console.WriteLine("**********Search Hostel students details based on different Inputs******");
            Console.WriteLine("1.Student Name   2.Student Room Type 3.student fee 4.student phone Number"+"\n 5.student Id");
           Console.WriteLine("Select your Choice");
            if(int.TryParse(Console.ReadLine(),out Userchoice))
            {
              switch(Userchoice)
              {
                case 1:
                    Console.WriteLine("Enter student Name");
                    name=Console.ReadLine();

                 foreach(XElement students in RootElement.Elements("Student"))
                 {
                if (students.Value==name)
                {
                    Console.WriteLine("\nName:{0}",students.Value);
                    Console.WriteLine("Id:{0} JoinigDate:{1}  Room Type:{2} Fee: RS.{3} PhoneNumber:{4} Address:{5} \n", students.Attribute("Id").Value, students.Attribute("JoiningDate").Value,
                    students.Attribute("RoomType").Value, students.Attribute("Fee").Value, students.Attribute("PhoneNumber").Value,
                    students.Attribute("Address").Value);   
                }              
               }  
                       
                break;

                case 2:
                Console.WriteLine("Enter Hostel Room Type");
                roomtype = Console.ReadLine();
                foreach (XElement students in RootElement.Elements("Student"))
                {
                    if (students.Attribute("RoomType").Value == roomtype)
                    {
                        Console.WriteLine("\nName:{0}", students.Value);
                        Console.WriteLine("Id:{0} JoinigDate:{1}  Room Type:{2} Fee: RS.{3} PhoneNumber:{4} Address:{5} \n", students.Attribute("Id").Value, students.Attribute("JoiningDate").Value,
                        students.Attribute("RoomType").Value, students.Attribute("Fee").Value, students.Attribute("PhoneNumber").Value,
                        students.Attribute("Address").Value);
                    }
                } 

                     break;

                case 3:
                     Console.WriteLine("Enter student fee");
                     fee = Console.ReadLine();
                     foreach (XElement students in RootElement.Elements("Student"))
                     {
                         if (students.Attribute("Fee").Value == fee)
                         {
                             Console.WriteLine("\nName:{0}", students.Value);
                             Console.WriteLine("Id:{0} JoinigDate:{1}  Room Type:{2} Fee: RS.{3} PhoneNumber:{4} Address:{5} \n", students.Attribute("Id").Value, students.Attribute("JoiningDate").Value,
                             students.Attribute("RoomType").Value, students.Attribute("Fee").Value, students.Attribute("PhoneNumber").Value,
                             students.Attribute("Address").Value);
                         }
                     } 

                    break;
                  case 4:
                    Console.WriteLine("Enter student Phone Number");
                    phonenumber = Console.ReadLine();
                    foreach (XElement students in RootElement.Elements("Student"))
                    {
                        if (students.Attribute("PhoneNumber").Value == phonenumber)
                        {
                            Console.WriteLine("\nName:{0}", students.Value);
                            Console.WriteLine("Id:{0} JoinigDate:{1}  Room Type:{2} Fee: RS.{3} PhoneNumber:{4} Address:{5} \n", students.Attribute("Id").Value, students.Attribute("JoiningDate").Value,
                            students.Attribute("RoomType").Value, students.Attribute("Fee").Value, students.Attribute("PhoneNumber").Value,
                            students.Attribute("Address").Value);
                        }
                    }

                    break;
                  case 5:
                    Console.WriteLine("Enter student Id");
                    id = Console.ReadLine();
                    foreach (XElement students in RootElement.Elements("Student"))
                    {
                        if (students.Attribute("Id").Value == id)
                        {
                            Console.WriteLine("\nName:{0}", students.Value);
                            Console.WriteLine("Id:{0} JoinigDate:{1}  Room Type:{2} Fee: RS.{3} PhoneNumber:{4} Address:{5} \n", students.Attribute("Id").Value, students.Attribute("JoiningDate").Value,
                            students.Attribute("RoomType").Value, students.Attribute("Fee").Value, students.Attribute("PhoneNumber").Value,
                            students.Attribute("Address").Value);
                        }
                    }

                    break;

            }
            }
                else
                    {
                        Console.WriteLine("Invalid choice.please try again");

                    }
            }
            }   
          
    }

