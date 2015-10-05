using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    class PNumber

    {

        private int enty,currentnumber=2;
        public static bool isPrime(int entry)
        {
            return entry % currentnumber == 0;
        }
    }
}
