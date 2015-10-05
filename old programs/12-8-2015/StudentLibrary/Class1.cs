using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
 public   class Class1:IcandidateDetails
    {

     public string Firstname
     {
         get;
         set;
     }

     public string Lastname
     {
         get;
         set;
     }

     public string Parent_Gaurdianname
     {
         get;
         set;
     }

     public string DateOfBirth
     {
         get;
         set;
     }

     public string Phno
     {
         get;
         set;
     }

     public string Qualification
     {
         get;
         set;
     }

     public string EmailId
     {
         get;
         set;
     }

     public string Parentphno
     {
         get;
         set;
     }
     string s=string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",Firstname,Lastname,Parent_Gaurdianname,);
     public override string ToString()
     {
         return string
     }
    }
}
