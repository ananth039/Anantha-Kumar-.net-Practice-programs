using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParametersDemo
{
    class Test 
    {
        public string GetBigAndSmall(string s1, string s2, out string small) 
        { 
            string big; 
            if (s1.Length > s2.Length) 
                big = s1; 
            else big = s2; 
            if (s1.Length < s2.Length) 
                small = s1;
            else small = s2;
            return (big);
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            string s1 = "dotnet";
            string s2 = "framework"; 
            string small; //no need of initialization 
            string big;
            big = t.GetBigAndSmall(s1, s2, out small);
            Console.WriteLine("Small string: " + small);
            Console.WriteLine("Big string: " + big);
            Console.Read();
        }
    }
}
