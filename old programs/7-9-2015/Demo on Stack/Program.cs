using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_on_Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            var alphabet=new Stack<char>();
            alphabet.Push('A');
            alphabet.Push('B');
            alphabet.Push('C');
            alphabet.Push('D');
            Console.WriteLine("Stack");
            foreach(char c in alphabet)
            {
               
                Console.WriteLine(c);
            }
            Console.WriteLine();
            //Search the value in the stack
            Console.WriteLine("Search the value in the stack using Contains(char)");
            if(alphabet.Contains('A'))
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("NOt Ok");
            }
            Console.WriteLine();
            Console.WriteLine("First iteration: push operation ");
            foreach (char c in alphabet)
            {
                
                Console.WriteLine(c);
                
                
            }
            Console.WriteLine();
            Console.WriteLine("top element in stack:"+alphabet.Peek());
            Console.WriteLine();
            Console.WriteLine("Second iteration:pop operation");
          

            while(alphabet.Count>0)
            {
                Console.WriteLine(alphabet.Pop());
                Console.WriteLine("\n Stack Elements:"+alphabet.Count+"\n");
            }
            Console.WriteLine();
        }
    }
}
