using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    class AnimalToy:IToy
    {
        public void MakeSound()
        {
            Console.WriteLine("Animal Toy make sound");
        }

        public void start()
        {
            Console.WriteLine("Animal toy is started");
        }

        public void stop()
        {
            Console.WriteLine("Animal toy is stopped"); 
        }
    }
}
