using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto03_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo
            Console.Write("Tu nombre: ");
            string nombre = Console.ReadLine();

            switch (nombre)
            {
                case "Juan": Console.WriteLine("Bienvenido, Juan.");
                    break;
                case "Pedro": Console.WriteLine("Que tal estas, Pedro");
                    break;
                default: Console.WriteLine("Procede con cautela, desconocido.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
