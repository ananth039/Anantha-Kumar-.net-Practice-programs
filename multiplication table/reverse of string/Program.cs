using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_of_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="ananth", rvstr="";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rvstr = rvstr + str[i];

            }
            Console.WriteLine(rvstr);
        }
    }
}
