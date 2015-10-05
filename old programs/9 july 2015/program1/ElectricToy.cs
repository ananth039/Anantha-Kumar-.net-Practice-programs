using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program1
{
    //dervied class
    class ElectricToy:Toy
    {
        //Method overriding(run time polymorphism)
        public override void Run()
        {
            Console.WriteLine("Run in Remote");
           
        }
        //method hidding(static polymorphism)
        public new void MakeSound()
        {
            Console.WriteLine("Toy Make Sound");
        }
    }
}
