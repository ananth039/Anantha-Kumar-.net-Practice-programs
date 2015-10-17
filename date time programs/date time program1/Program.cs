using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_time_program1
{
    class Program
    {
        static void Main(string[] args)
        {
           
List<string> list = new List<string>();
foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
{
  string specName = "(none)";
  try { specName = CultureInfo.CreateSpecificCulture(ci.Name).Name; } catch { }
  list.Add(String.Format("{0,-12}{1,-12}{2}", ci.Name, specName, ci.EnglishName));
}

list.Sort();  // sort by name

// write to console
Console.WriteLine("CULTURE   SPEC.CULTURE  ENGLISH NAME");
Console.WriteLine("--------------------------------------------------------------");
foreach (string str in list)
  Console.WriteLine(str);
        }
    }
}
