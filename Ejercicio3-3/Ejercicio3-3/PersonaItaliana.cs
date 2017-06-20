using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_3
{
    public class PersonaItaliana : Persona
    {
        public new void Saludar()
        {
            Console.Write("Ciao, sono {0}", Nombre);
            Console.WriteLine(" e ho {0} anni\n", Edad);
        }
    }
}
