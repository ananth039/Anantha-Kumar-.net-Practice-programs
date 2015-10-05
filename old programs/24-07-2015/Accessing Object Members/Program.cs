using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessing_Object_Members
{
    class test
    {
        //fields
        public string str = "windows"; 
        public int num = 90251;
        //methods
        public void ReverseString()
        { 
            string r = ""; 
            int i; int len = str.Length;
            for (i = len - 1; i >= 0; i--) 
                r = r + str[i];
            Console.WriteLine("Reversed string is: " + r);
        }
        public void ReverseNumber() 
        { 
            string s = num.ToString(); 
            string r = "";
            int i; 
            int len = s.Length;
            for (i = len - 1; i >= 0; i--)
                r = r + s[i]; 
            Console.WriteLine("Reversed string is: " + r);
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            //construct  an object
            test t = new test(); 
            //access fields 
            Console.WriteLine(t.num);
            Console.WriteLine(t.str); 
            //access methods
            t.ReverseString();
            t.ReverseNumber();
            Console.Read();

        }
    }
}
