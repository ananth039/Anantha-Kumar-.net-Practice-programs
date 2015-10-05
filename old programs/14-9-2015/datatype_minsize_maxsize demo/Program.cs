using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype_minsize_maxsize_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("SByte min value {0} , SByte max value {1} ",sbyte.MinValue,sbyte.MaxValue);
            
            Console.WriteLine("Byte min value {0} , Byte max value {1} ", byte.MinValue, byte.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Short min value {0} , Short max value {1} ",Int16.MinValue,Int16.MaxValue);
            Console.WriteLine("UShort min value {0} , UShort max value {1} ", UInt16.MinValue, UInt16.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Int Min Value {0} , Int Max Max Value {1} ",Int32.MinValue,Int32.MaxValue);
            Console.WriteLine("UInt Min value {0} , UInt Max value  {1}",UInt32.MinValue,UInt32.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Long min value {0} , Long Max value {1}",Int64.MinValue,Int64.MaxValue);
            Console.WriteLine("ULong min value {0} , ULong max value {1}",UInt64.MinValue,UInt64.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Float min value {0} , Float max value {1}",float.MinValue,float.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Double min vlaue {0} , Double max valuem {1}",double.MinValue,double.MaxValue);
            Console.WriteLine();
            Console.WriteLine("decimal min value {0} , Decimal max value {1}",decimal.MinValue,decimal.MaxValue);
            Console.WriteLine(  );
            Console.WriteLine("char min value {0} ,char Max value {1} ",char.MinValue,char.MaxValue);
           
        }

    }
}
