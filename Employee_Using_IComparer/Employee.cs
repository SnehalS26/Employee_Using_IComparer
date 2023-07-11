using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Using_IComparer
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class SalaryComaprision : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if(x.Salary < y.Salary)
            {
                return -1;
            }
            else if(x.Salary > y.Salary)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
