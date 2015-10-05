using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Test";
            s.Id = 1;
            s.Address = "Test";
            s.DisplayMessage();
            Console.ReadLine();

            s.DisplayMessageUsingAction(Log);

            Console.ReadLine();
            s.DisplayMessageUsingAction(LogMe);
        }

        static void Log(string message)
        {
            Console.WriteLine("My Log {0}:{1}", DateTime.Now, message);
        }

        static void LogMe(string message)
        {
            Console.WriteLine("DelegatesDemo {0}:{1}- {2}", DateTime.Now, message, "Program");
        }

        }
    }

