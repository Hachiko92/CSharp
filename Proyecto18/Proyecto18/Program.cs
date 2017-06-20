using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce nombre: ");
            string nombre = Console.ReadLine();
            Empleado emple = new Empleado();
            emple.imprimir(nombre);

            Console.ReadLine();
        }
    }
}
