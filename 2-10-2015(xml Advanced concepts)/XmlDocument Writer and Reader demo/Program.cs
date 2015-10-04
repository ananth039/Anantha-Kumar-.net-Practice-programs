using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDocument_Writer_and_Reader_demo
{
    class Program
    {
        static void Main(string[] args)
        {

             string id,joiningdate,roomtype,fee,name,phone,address,choice="yes",choice2="yes";
            int UserChoice;
             XmlDocument document = new XmlDocument();
            XmlElement HostelElement = document.CreateElement("Hostel"); //create hostel is root element
            do
            {
            Console.WriteLine("*************Hostel Student Registration***********");
            Console.WriteLine("1.student Registration 2.Display students in hostel");
            Console.WriteLine("Select your Choice");
            UserChoice=int.Parse(Console.ReadLine());
            switch(UserChoice)
            {
                case 1:
                    do
                    {
            
                XmlElement StudentElement = document.CreateElement("Student");   //create student element is sub element 

                //student attributes are id,join date, Room Type,fee 

                XmlAttribute idAttribute = document.CreateAttribute("Id");
                XmlAttribute joinDateAttribute = document.CreateAttribute("JoiningDate"); //create the joinDate attribute
                XmlAttribute RoomTypeAttribute = document.CreateAttribute("RoomType"); //create the room Type attribute
                XmlAttribute FeeAttribute = document.CreateAttribute("Fee"); //create the fee attribute
                XmlElement NameElement = document.CreateElement("Name");
                XmlElement PhoneNumberElement = document.CreateElement("PhoneNumber");
                XmlElement AddressElement = document.CreateElement("Address");

                Console.WriteLine("Enter student id");
                id = Console.ReadLine();
                Console.WriteLine("Enter student Name");
                name = Console.ReadLine();
                Console.WriteLine("Enter studnet phone number");
                phone = Console.ReadLine();
                Console.WriteLine("Enter student Address");
                address = Console.ReadLine();
                Console.WriteLine("Enter student joining date");
                joiningdate = Console.ReadLine();
                Console.WriteLine("Enter Hostel room type");
                roomtype = Console.ReadLine();
                Console.WriteLine("Enter hostel fee");
                fee = Console.ReadLine();


                idAttribute.Value = id;   //id attribute value
                joinDateAttribute.Value =joiningdate;   // joindate attribute value
                RoomTypeAttribute.Value = roomtype; //room type attribute value
                FeeAttribute.Value = fee; //fee attribute value

                StudentElement.Attributes.Append(idAttribute);    //id attribute is add to student
                StudentElement.Attributes.Append(joinDateAttribute); //join  date is add to student
                StudentElement.Attributes.Append(RoomTypeAttribute); //Room type is add to student
                StudentElement.Attributes.Append(FeeAttribute); //fee is add to student

                //student inner elements are Name ,Phone Number,Address


                NameElement.InnerText = name;    //name element inner text(value)
                PhoneNumberElement.InnerText = phone; //phone number inner text value
                AddressElement.InnerText = address;       //Address inner text value

                StudentElement.AppendChild(NameElement); //name  element is add to student
                StudentElement.AppendChild(PhoneNumberElement); //phone number is add to student
                StudentElement.AppendChild(AddressElement);  //address is add to student

                HostelElement.AppendChild(StudentElement); //Student Element is add to hostel

                document.AppendChild(HostelElement);   //Hostel root element is added to document

                document.Save("HostelInformation.xml");  //save the data in xml

                Console.WriteLine(" your infomation is Sucesssfully  Saved");
                 Console.WriteLine("\nDo you want add students or press enter");
                choice = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(choice));
                 break;

                case 2:
                    Console.WriteLine("Students details");
                    document.Load("HostelInformation.xml");
                    XmlNodeList StudentList=document.SelectNodes("Hostel/Student");
                    //XmlNodeList studentNameList=document.SelectNodes("Hostel/Student/Name");
                    //XmlNodeList studnetPhoneList = document.SelectNodes("Hostel/Student/PhoneNumber");
                    //XmlNodeList studentAddresList = document.SelectNodes("Hostel/Student/Address");
                    foreach(XmlNode student in StudentList)
                    { 
                        Console.WriteLine(student.InnerText);
                        Console.WriteLine("\n{0}  date:{1}   {2}     Rs:{3}\n", student.Attributes.GetNamedItem("Id").Value,student.Attributes.GetNamedItem("JoiningDate").Value, student.Attributes.GetNamedItem("RoomType").Value,
                   student.Attributes.GetNamedItem("Fee").Value);
                        //foreach (XmlNode names in studentNameList)
                        //{
                        //    Console.Write(names.InnerText + " ");
                        //}
                        //foreach (XmlNode phones in studnetPhoneList)
                        //{
                        //    Console.Write(phones.InnerText + " ");
                        //}
                        //foreach (XmlNode adrs in studentAddresList)
                        //{
                        //    Console.Write(adrs.InnerText + " ");
                        //}
                    }
                  
                    break;
            }
                Console.WriteLine("\nDo you want continue or press enter");
                choice = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(choice));
        
        }
    }
}
