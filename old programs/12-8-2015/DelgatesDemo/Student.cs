using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgatesDemo
{

    public delegate void PrintMessage(string message);

    class Student
    {
        private Func<int, string> ConversionFunction;
        public string Name { get; set; }

        public string Address { get; set; }

        public int Id { get; set; }

        public void DisplayMessage()
        {
            PrintMessage message = new PrintMessage(Console.WriteLine);
            message(Name);
            message(Address);
            message(Id.ToString());
            message.Invoke(Name);

            PrintMessage message2 = (Log);
            message2(Name);
            message2(Address);
            message2(Id.ToString());

            Console.WriteLine("Adding delegats");
            PrintMessage message3 = message + message2;


            message3(Name);
            message3(Address);
            message3(Id.ToString());



        }

        public void DisplayMessageUsingAction(Action<string> printMessageAction)
        {
            ConversionFunction = GetIdAsString;
            printMessageAction.Invoke(Name);
            printMessageAction.Invoke(Address);
            printMessageAction.Invoke(ConversionFunction.Invoke(Id));
        }

        private void Log(string message)
        {
            Console.WriteLine("{0}:{1}", DateTime.Now, message);
        }

        public static string GetIdAsString(int id)
        {
            return id.ToString();
        }


    }
}
