using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XElement__searching_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement RootElement = XElement.Load("HostelInformation.xml");

            Console.WriteLine("\n*** students Details based on 5 sharing Rooms***\n");
            foreach(XElement students in RootElement.Elements("Student"))
            {
                if (students.Attribute("RoomType").Value =="5 sharing")
                {
                    Console.WriteLine("Name:{0}",students.Value);
                    Console.WriteLine("{0} {1} {2} RS:{3} {4} {5} \n", students.Attribute("Id").Value, students.Attribute("JoiningDate").Value,
                   students.Attribute("RoomType").Value, students.Attribute("Fee").Value, students.Attribute("PhoneNumber").Value,
                   students.Attribute("Address").Value);
                }
               
            }

            Console.WriteLine("\n*** students Details Based on 3 Sharing Rooms***\n");
            foreach (XElement students in RootElement.Elements("Student"))
            {
                if (students.Attribute("RoomType").Value == "3 sharing")
                {
                    Console.WriteLine("Name:{0}", students.Value);
                    Console.WriteLine("{0} {1} {2} RS:{3} {4} {5} \n", students.Attribute("Id").Value, students.Attribute("JoiningDate").Value,
                   students.Attribute("RoomType").Value, students.Attribute("Fee").Value, students.Attribute("PhoneNumber").Value,
                   students.Attribute("Address").Value);
                }

            }
            Console.WriteLine("\n***students details based on fee ***\n");
            foreach (XElement students in RootElement.Elements("Student"))
            {
                if (students.Attribute("Fee").Value == "3500")
                {
                    Console.WriteLine("Name:{0}", students.Value);
                    Console.WriteLine("{0} {1} {2} RS:{3} {4} {5} \n", students.Attribute("Id").Value, students.Attribute("JoiningDate").Value,
                   students.Attribute("RoomType").Value, students.Attribute("Fee").Value, students.Attribute("PhoneNumber").Value,
                   students.Attribute("Address").Value);
                }

            }
           


        }
    }
}
