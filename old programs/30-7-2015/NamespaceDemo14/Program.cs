using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ananth.example.practice.Namespaces1.test2;
using NamespaceLibrary1 = Ananth.example.practice.NamespacesLibrary;

namespace NamespaceDemo14
{
    class Program
    {
        static void Main(string[] args)
        {
            Ananth.example.practice.Namespaces.test1 test1 = new Namespaces.test1.test1();
            test2 test2 = new test2();


        }
    }
}
