using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please choose one option for following Menu.\n Int-->1  double -->2  float-->3 \n please enter One value to compute square");
            int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("enter one integer number ");
                        int n = int.Parse(Console.ReadLine());
                        //int square calucations
                        int n1 = n * n;
                        Console.WriteLine("{0} square is: {1}", n, n1);
                        break;

                    case 2:
                        Console.WriteLine("enter one double number ");
                        double d = double.Parse(Console.ReadLine());
                        //double Square calculations
                        double d1 = d * d;
                        Console.WriteLine("{0} square is: {1}", d, d1);
                        break;

                    case 3:
                        Console.WriteLine("enter one floating point number ");
                        float f = float.Parse(Console.ReadLine());
                        //float square calculations
                        float f1 = f * f;
                        Console.WriteLine("{0} square is: {1}", f, f1);
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }
           
            
        }
    }

}