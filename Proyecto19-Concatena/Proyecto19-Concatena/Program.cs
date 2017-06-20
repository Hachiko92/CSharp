using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto19_Concatena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Concatena conca = new Proyecto19_Concatena.Concatena(nombre, apellido);
            string nombreCompleto = conca.concatenar();

            Console.WriteLine("\nEl nombre completo es: {0}", nombreCompleto);

            Console.ReadLine();
        }
    }
}
