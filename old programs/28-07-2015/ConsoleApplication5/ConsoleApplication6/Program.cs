﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a string");
string input;
input = Console.ReadLine();
if (input == "")
{
Console.WriteLine("You typed in an empty string.");
}
else if (input.Length < 5)
{
Console.WriteLine("The string had less than 5 characters.");
}
else if (input.Length < 10)
{
Console.WriteLine("The string had at least 5 but less than 10 Characters.");
}
Console.WriteLine("The string was " + input);
}
        }
    }
