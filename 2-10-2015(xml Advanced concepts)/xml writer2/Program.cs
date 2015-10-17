using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xml_writer2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
             string choice;

            XmlElement businfo = doc.CreateElement("buses");
            do
            {
                XmlElement buselement = doc.CreateElement("bus");
                XmlAttribute busnumattribute = doc.CreateAttribute("busnum");
                XmlAttribute stimeattribute = doc.CreateAttribute("startingtime");
                XmlAttribute etimeattribute = doc.CreateAttribute("departuretime");

                XmlElement bookingelement = doc.CreateElement("bookingtype");
                XmlElement costelement = doc.CreateElement("price");
                XmlElement seatselement = doc.CreateElement("numofseats");

                Console.WriteLine("enter busnum");
                String busnum = Console.ReadLine();
                Console.WriteLine("enter starting time");
                String startingtime = Console.ReadLine();
                Console.WriteLine("enter departuretime");
                String departuretime = Console.ReadLine();
                Console.WriteLine("enter bookintype");
                String bookingtype = Console.ReadLine();

                Console.WriteLine("enter price");
                String price = Console.ReadLine();
                Console.WriteLine("enter num of seats");
                String numofseats = Console.ReadLine();


                busnumattribute.Value = busnum;
                stimeattribute.Value = startingtime;
                etimeattribute.Value = departuretime;

                bookingelement.InnerText = bookingtype;
                costelement.InnerText = price;
                seatselement.InnerText = numofseats;

                buselement.Attributes.Append(busnumattribute);
                buselement.Attributes.Append(stimeattribute);
                buselement.Attributes.Append(etimeattribute);

                buselement.AppendChild(bookingelement);
                buselement.AppendChild(costelement);
                buselement.AppendChild(seatselement);

                businfo.AppendChild(buselement);
                doc.AppendChild(businfo);
                doc.Save("businfo.xml");
               
                Console.WriteLine("Do you want add more records yes or not press enter");
                choice = Console.ReadLine();
            } while (!string.IsNullOrEmpty(choice));
          
         
        }
    }
}
