using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Writing_in_to_text_file
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter tt = new StreamWriter("e://php//test.txt");
            string input;
        
            for(int i=1;i<=5;i++)
            {
                Console.WriteLine("enter your sample input");
                input = Console.ReadLine();
               outFile.WriteLine(input);
                
            }
            outFile.close();
        }
    }
}
