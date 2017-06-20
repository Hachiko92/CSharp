using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_3
{
    public class PersonaInglesa : Persona
    {
        public void TomarTe()
        {
            Console.WriteLine("I'm drinking té\n");
        }

        public new void Saludar()
        {
            Console.Write("Hi, I am {0}", Nombre);
            Console.WriteLine(" and I'm {0} years old", Edad);
        }
    }
}
