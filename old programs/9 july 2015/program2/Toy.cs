﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program2
{
    //Base class
    class Toy
    {
        //method overridding(run time polymorphism)
        public virtual void Run()
        {
            Console.WriteLine("Run Mechanically");
        }
        //method hiding(static polymorphism)
        public void MakeSound()
        {
            Console.WriteLine("Toy Make Sound");
        }
    }
}
