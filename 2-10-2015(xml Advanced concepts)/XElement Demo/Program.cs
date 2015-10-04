using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XElement_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement root = XElement.Load("HostelInformation.xml");
           // XElement rootElement = XElement.Load("HostelInformation.xml");
            foreach (XElement element in root.Elements("Student"))
            {
                Console.WriteLine(element.Value.Trim());
                Console.WriteLine("{0} {1} {2} RS:{3} {4} {5}", element.Attribute("Id").Value, element.Attribute("JoiningDate").Value,
                    element.Attribute("RoomType").Value, element.Attribute("Fee").Value, element.Attribute("PhoneNumber").Value,
                    element.Attribute("Address").Value);
            }

        }
        
    }
}
