using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy_diwali
{
    class Program
    {
        static void Main(string[] args)
        {
            string wishes = " Advanced Happy Diwali to All";
            string msg = " May  Goddess Laxmi and  Lord Ganesha bless you and \n your family a bright and Colourful Diwali in Advance Happy diwali";
            for(int i=0;i<wishes.Length;i++)
            {

                Console.WriteLine(i+".  " +wishes);
              
            }
            Console.WriteLine("\n********************************************************************");
            Console.WriteLine(msg);
            Console.WriteLine("******************************************************************** \n");

        }

    }
}
