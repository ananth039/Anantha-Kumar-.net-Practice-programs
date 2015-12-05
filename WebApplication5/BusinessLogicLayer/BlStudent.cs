using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class BlStudent
    {

        DaStudent dastd = new DaStudent();
        public int  InsertStudentDetails(DaStudent dastd)
        {
          
            dastd.Result = GetResult();
            return dastd.InsertStudentDetails(dastd);

        }
        public string GetResult()
        {
            int m1=dastd.Subject1;
            int m2=dastd.Subject2;
            int m3=dastd.Subject3;
            int total=m1+m2+m3;
            int avg=total/3;
            string result = "";
            
            if (avg >=60)
            {
                result = "First Class";
            }
            else if (avg >=50 && avg<60)
             {
                result = "Second Class";
            }
            else if (avg >=35&&avg<=50)
            {
          result = "Third Class";
            }
               
            else
             {
                result = "Fail";
              }

            return result;
         
        }
    }
    }

