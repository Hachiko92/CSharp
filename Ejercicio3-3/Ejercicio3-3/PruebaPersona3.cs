using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_3
{
    class PruebaPersona3
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            PersonaInglesa p2 = new PersonaInglesa();
            PersonaInglesa p3 = new PersonaInglesa();
            PersonaItaliana p4 = new PersonaItaliana();

            p.Nombre = "Juan";
            p.Edad = (p.CalcularEdad(1965));

            p2.Nombre = "Eva";
            p2.Edad = (p.CalcularEdad(1978));

            p3.Nombre = "Carl";
            p3.Edad = (p.CalcularEdad(1984));

            p4.Nombre = "Mario";
            p4.Edad = (p.CalcularEdad(1980));

            p.Saludar();
            p2.Saludar();
            p2.TomarTe();
            p3.Saludar();
            p3.TomarTe();
            p4.Saludar();


            Console.ReadLine();

        }
    }
}
