using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQ_to_Arrays 
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 12, 10, 5, 15, 4, 62 }; 

            //Linq query
            IEnumerable<int> result = from n in numbers where n <= 10 select n;
            foreach(var x in result)
                Console.WriteLine(x);
        }
    }
}
