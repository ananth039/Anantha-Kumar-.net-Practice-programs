using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Car_task
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int mileage = 21;
            string color;
            bool isGermanManu = false;
            Regex validate = new Regex("^W+[A-Za-z]*N$");
            string completeName;
            string ModelName;
            string[] typeOfAccessories = new string[2];
            string companyname;
            string CarManufacture;
            string accesories1;
            string accesories2;

            isGermanManu = IsGoodcar(isGermanManu, validate, typeOfAccessories, out color, out completeName, out ModelName, out companyname, out CarManufacture, out accesories1, out accesories2);
            Console.WriteLine("your car is good car");

        }

        private static bool IsGoodcar(bool isGermanManu, Regex validate, string[] typeOfAccessories, out string color, out string completeName, out string ModelName, out string companyname, out string CarManufacture, out string accesories1, out string accesories2)
        {
            //read the user input values
            Console.WriteLine("please enter company name");
            companyname = Console.ReadLine();


            if (!validate.IsMatch(companyname))
            {
                Console.WriteLine("Company name is start with W and end with N");
            }


            Console.WriteLine("please enter car Model Name");
            ModelName = Console.ReadLine();
            if (ModelName.Length > 7)
            {
                Console.WriteLine("model Name is contains at leaset 7 characters");

            }





            Console.WriteLine("please enter car Color either white or silver");
            color = Console.ReadLine();
            if (!(color.Equals("white") || color.Equals("silver")))
            {
                Console.WriteLine("car color should be white or silver");
            }

            Console.WriteLine("please enter car manufacture");
            CarManufacture = Console.ReadLine();

            if (CarManufacture.Equals("german"))
            {
                isGermanManu = true;
            }
            else
            {
                Console.WriteLine("car manufacture should be german");
            }


            Console.WriteLine("acessories are Ac,Stereo, Seat Covers,AirBags. please enter two acessories");
            Console.WriteLine("please enter acessories 1");
            accesories1 = Console.ReadLine();


            Console.WriteLine("please enter acessories 2");
            accesories2 = Console.ReadLine();

            typeOfAccessories[0] = accesories1;
            typeOfAccessories[1] = accesories2;
            completeName = companyname + "-" + ModelName;
            return isGermanManu;
        }
    }
   
}
