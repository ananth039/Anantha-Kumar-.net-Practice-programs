using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passing_arguments_to_Main___Method
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            { 
                Console.WriteLine(args.Length + " arguments found. Those are:");
                for (int i = 0; i < args.Length; i++) 
                    Console.WriteLine(args[i]); 
            } 
            else Console.WriteLine("No arguments found...");
            Console.Read();
        }
        }
    }
