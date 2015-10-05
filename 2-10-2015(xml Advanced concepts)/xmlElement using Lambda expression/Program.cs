using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xmlElement_Lambda_expression_select
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement StudentRootElement = XElement.Load("HostelInformation.xml");
            foreach (string item in StudentRootElement.Elements("Student").Select(item => item.Value.Trim()))
            {
                Console.WriteLine(item);
              //  Console.WriteLine("{0},{1},{2},[3},{4},{5}"
                 //   , item.Attribute("Id"), item.Attribute("JoiningDate").Value, item.Attribute("RoomType").Value, item.Attribute("Fee").Value, item.Attribute("PhoneNumber").Value, item.Attribute("Address").Value);
            }


        }



    }
}