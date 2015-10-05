using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
   public interface IAcademicDetails
    {
      string Qualification { set; get; }
      string YearOfPass { set; get; }
        string Percentage { set; get; }
    }
}
