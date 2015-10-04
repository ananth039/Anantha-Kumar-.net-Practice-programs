using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDocument_writer_with_xmlElelementXmlAttribute_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            XmlElement HostelElement = document.CreateElement("Hostel"); //create hostel is root element

            XmlElement StudentElement = document.CreateElement("Student");   //create student element is sub element 

            //student attributes are id,join date, Room Type,fee 

            XmlAttribute idAttribute=document.CreateAttribute("Id");
            idAttribute.Value = "1";   //id attribute value
            XmlAttribute joinDateAttribute = document.CreateAttribute("JoiningDate"); //create the joinDate attribute
            joinDateAttribute.Value = "01-10-2015";   // joindate attribute value
            XmlAttribute RoomTypeAttribute = document.CreateAttribute("RoomType"); //create the room Type attribute
            RoomTypeAttribute.Value = "3share"; //room type attribute value
            XmlAttribute FeeAttribute = document.CreateAttribute("Fee"); //create the fee attribute
            FeeAttribute.Value = "3400"; //fee attribute value

            
            
            StudentElement.Attributes.Append(idAttribute);    //id attribute is add to student
            StudentElement.Attributes.Append(joinDateAttribute); //join  date is add to student
            StudentElement.Attributes.Append(RoomTypeAttribute); //Room type is add to student
            StudentElement.Attributes.Append(FeeAttribute); //fee is add to student

            //student inner elements are Name ,Phone Number,Address

            XmlElement NameElement = document.CreateElement("Name");  
            NameElement.InnerText="Kumar";    //name element inner text(value)
            XmlElement PhoneNumberElement = document.CreateElement("PhoneNumber");
            PhoneNumberElement.InnerText = "98486485454"; //phone number inner text value
            XmlElement AddressElement= document.CreateElement("Address");
            AddressElement.InnerText = "rjy";       //Address inner text value

            StudentElement.AppendChild(NameElement); //name  element is add to student
            StudentElement.AppendChild(PhoneNumberElement); //phone number is add to student
            StudentElement.AppendChild(AddressElement);  //address is add to student

            HostelElement.AppendChild(StudentElement); //Student Element is add to hostel

            document.AppendChild(HostelElement);   //Hostel root element is added to document

            document.Save("HostelInformation.xml");  //save the data in xml
            Console.WriteLine(" your infomation is Sucesssfully  Saved");




            

        }
    }
}
