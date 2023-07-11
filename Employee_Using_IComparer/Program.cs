using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Using_IComparer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee{ Name = "Snehal" , Salary = 20000};
            Employee emp1 = new Employee { Name = "Sneh", Salary = 15000 };

            SalaryComaprision sal = new SalaryComaprision();
            int result = sal.Compare(emp, emp1);

            if(result<0)
            {
                Console.WriteLine("Snehal has less salary than sneh");
            }
            else if(result>0)
            {
                Console.WriteLine("Snehal has more salary than sneh");
            }
            else
            {
                Console.WriteLine("Snehal & sneh has same salary");
            }
        }
    }
}
