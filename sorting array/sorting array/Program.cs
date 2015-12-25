using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 20, 80, 60, 40, 10, 52, 9, 75, 8, 1 };
            int n = arr.Length-1;
            int t;
            for(int i=1;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j + 1] = t;
                    }
                }
            }
            for(int k=0;k<n;k++)
            {
                Console.WriteLine(arr[k]);
            }

        }
    }
}
