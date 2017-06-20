using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto20_Constructor
{
    class Employee
    {
        private int salary;

        public Employee(int annualSalary)
        {
            salary = annualSalary;
        }
        public Employee(int weekSalary, int numberOfWeeks) : this(weekSalary * numberOfWeeks)
        {
            //salary = weekSalary * numberOfWeeks;
        }
        public void Pay()
        {
            Console.WriteLine("El empleado cobra {0}", salary);
        }
    }
}
