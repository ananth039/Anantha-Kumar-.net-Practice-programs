using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument studentsDocument = new XmlDocument();
            studentsDocument.Load("students.Xml");
            XmlNodeList studentNodeList = studentsDocument.SelectNodes("Students/Student");
            foreach (XmlNode studentNode in studentNodeList)
            {
                Console.WriteLine(studentNode.InnerText.Trim());
               // Console.WriteLine(studentNode.Attributes.GetNamedItem("id").Value);
            }
            //Console.WriteLine(studentsDocument.SelectSingleNode("/Students/Stuent").InnerText);
        }
    }






}