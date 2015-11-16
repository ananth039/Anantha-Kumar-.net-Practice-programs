using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_Pascal_s_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows,coef=1,space,i,j;
Console.WriteLine("Enter number of rows");
    rows=int.Parse(Console.ReadLine());
    for(i=0;i<rows;i++)
    {
        for(space=1;space<=rows-i;space++)
        Console.Write("  ");
        for(j=0;j<=i;j++)
        {
            if (j==0||i==0)
                coef=1;
            else
               coef=coef*(i-j+1)/j;
            Console.Write(coef);
        }
       Console.WriteLine(" ");
        }
    }
    }
}

