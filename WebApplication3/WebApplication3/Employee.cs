using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication3
{
    class Employee
    {
        public int eno{get;set;}
        public string ename {get;set;}
        public double salary {get;set;}
        public Employee(int eno,string ename,double salary)
        {
            this.eno = eno;
            this.ename = ename;
            this.salary = salary;
        }
    }
}
