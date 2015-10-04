using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDocument_Reader_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument BusesDocument = new XmlDocument();
           // BusesDocument.LoadXml("RedBusInformation.xml");
            //                or
            BusesDocument.Load("RedBusInformation.xml");
            XmlNodeList bussesInformationList = BusesDocument.SelectNodes("REDBus/RedBusesInfo/Bus");
            Console.WriteLine("***************RedBus**********\n");
            Console.WriteLine("Description:{0}\n",BusesDocument.SelectSingleNode("REDBus/Description").InnerText);
            Console.WriteLine("***********Busses Inforamation***********\n");
            foreach(XmlNode bus in bussesInformationList)
            {
                Console.WriteLine(bus.InnerText.Trim());
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} RS.{7}", bus.Attributes.GetNamedItem("id").Value, bus.Attributes.GetNamedItem("Type").Value, bus.Attributes.GetNamedItem("source").Value,
                    bus.Attributes.GetNamedItem("destination").Value, bus.Attributes.GetNamedItem("Depart").Value,bus.Attributes.GetNamedItem("Arrive").Value,
                    bus.Attributes.GetNamedItem("Duration").Value, bus.Attributes.GetNamedItem("fare").Value);
            }
            

        }
    }
}
