using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_or_odd_2
{
    class Number
    {
        private int entry;
        public static bool Iseven(int entry)
        {
            //assign argument value to field;
            return entry % 2 == 0;
        }
    }
}
