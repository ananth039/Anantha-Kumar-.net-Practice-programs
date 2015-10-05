using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
  public  interface IAddress
    {
      public string Drno { set; get; }
      public string street { set; get; }
      public string City_village { set; get; }
      public string District { set; get; }
      public string state { set; get; }
      public string Zipcode { set; get; }


    }
}
