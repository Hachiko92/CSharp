using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto12_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "alberto", "Juan", "Sergio" };

            // nombre (que se puede llamar en cualquier modo) debe ser del mismo tipo de el array que recorre
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
            Console.ReadLine();
        }
    }
}
