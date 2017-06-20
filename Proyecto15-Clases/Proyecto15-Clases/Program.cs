using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto15_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            // cualquier tipo de clase por defecto tiene un metodo constructor 
            Puerta p1 = new Puerta();

            p1.Alto = 23;
            p1.Ancho = 45;
            p1.Color = "rojo";

            p1.Abrir();
            p1.MostrarEstado();

            Porton port = new Porton();

            Console.ReadLine();
        }
    }
}
