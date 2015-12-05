using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class BlEmployee
    {
        DaEmployee daobject = new DaEmployee();
      public DataTable GetDeptData()
        {
            return daobject.GetDeptDetails();
        }
        public int InsertEmp(DaEmployee daobject)
      {
          daobject.Salary = GrossSalary();
          return daobject.InsertEmployeeDetails(daobject);

      }
        public int GrossSalary()
        {
            int hra = 1000;
            int da = 2000;
            int grossSal = daobject.Salary + hra + da;
            return grossSal;
        }
    }
}
