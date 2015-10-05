using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
  public interface IcandidateDetails
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Parent_Gaurdianname { get; set; }
        public string DateOfBirth { get; set; }
        public string Phno { get; set; }
        public string Qualification { get; set; }
        public string EmailId { get; set; }
        public string Parentphno { get; set; }
    }
}
