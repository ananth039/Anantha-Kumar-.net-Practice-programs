using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDocument_writer_with_Do._.@while
{
    class Program
    {
        static void Main(string[] args)
        {
            string id,joiningdate,roomtype,fee,name,phone,address,choice="yes";
            XmlDocument document = new XmlDocument();

            XmlElement HostelElement = document.CreateElement("Hostel"); //create hostel is root element

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
                joinDateAttribute.Value = name;   // joindate attribute value
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
                Console.WriteLine("Do you want add student or press enter");
                choice = Console.ReadLine();
            } while (!string.IsNullOrWhiteSpace(choice));
        }
    }
}
