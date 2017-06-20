using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto20_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(30000);
            Employee e2 = new Employee(500, 52);

            e1.Pay();
            e2.Pay();

            Console.ReadKey();
        }
    }
}
