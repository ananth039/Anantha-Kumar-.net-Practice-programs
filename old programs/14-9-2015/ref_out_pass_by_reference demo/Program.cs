using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_pass_by_reference_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double rate;
            double time=3;
            //value is assign in to time
            Console.WriteLine(GetInterst(2000,out rate,5));
            Console.WriteLine(rate);
            Console.WriteLine();
            //value is assign in to years
            Console.WriteLine(GetInterst2(2000,2,ref time));
            Console.WriteLine(time);

            
        }
        /// <summary>
        /// pass by reference using out 
        /// </summary>
        /// <param name="price"></param>
        /// <param name="rateOfInterst"></param>
        /// <param name="years"></param>
        /// <returns></returns>
        public static double GetInterst(double price,out double rateOfInterst,double years)
        {
            rateOfInterst=2;
            return price*rateOfInterst*years/100;
        }
        //pass by reference using ref
        public static double GetInterst2(double price, double rateOfInterst, ref double years)
        {
            years++;
            return price * rateOfInterst * years / 100;

        }
    }
}
