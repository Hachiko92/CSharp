using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto16_Clases2
{
    class PruebaPersona
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Nombre = "Juan";
            p.Edad = (p.CalcularEdad(1965));
            p.Saludar();

            Persona p2 = new Persona();
            p.Nombre = "Ines";
            p.Edad = (p.CalcularEdad(1995));
            p.Saludar();

            Console.ReadLine();
        }
    }
}
