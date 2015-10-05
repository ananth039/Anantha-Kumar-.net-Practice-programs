using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
  public   class Student1
    {
        public string Name
        {
            set;
            get;
        }
        public string course
        {
            set;
            get;
        }
        public string phno
        {
            set;
            get;
        }
        public override string ToString()
        {
            return Name + " " + course + " " + phno;
        }
    }
}