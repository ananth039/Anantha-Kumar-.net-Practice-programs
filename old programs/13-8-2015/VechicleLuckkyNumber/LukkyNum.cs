using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleLuckkyNumber
{
 public   class LukkyNum
    {
       private int num,num1;

     
        public void Luckky()
        {
            Console.WriteLine("Enter vechicle number");
            num = int.Parse(Console.ReadLine());
            string nummm = num.ToString();
            string r = "";
            int len=nummm.Length;
            int ss=0;
            int r1;
            int ee;
            for (int i = len - 1; i >= 0; i--)
            {
                r = r + nummm[i];
             
               Console.WriteLine("    "+r);
                ss = Convert.ToInt16(r);
               ee  =+ss;
               int ssq = ee;
               Console.WriteLine("o"+ee);
              
            }
          
        }
    }
}
