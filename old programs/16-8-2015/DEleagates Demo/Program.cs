using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annmoyusmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string mid = " , middle part ,";
            Func<string,string> annodel=delegate(string param)
            {
                param +=mid;
                param +=" and this was add to string \n";
                return param;
            };
        Console.WriteLine(annodel("Strat of string"));

// action kike as void method
      Action<int>  DisplayAction = (n => Console.WriteLine(n.ToString()));
      DisplayAction(10);
// function has return method
      Func<string, int> myfunction;
      myfunction = int.Parse;
  
      int i = myfunction.Invoke("10");
      Console.WriteLine( i);
        }
    }
}
