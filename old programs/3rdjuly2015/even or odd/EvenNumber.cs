using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_or_odd
{
    class EvenNumber
    {
        private int entry;
        public bool IsEven(int entry)
        {
            this.entry=entry;
            return entry % 2 == 0;
        }
    }
}
