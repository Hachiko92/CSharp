using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_2
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public int CalcularEdad(int anioNacimiento)
        {
            return (2017 - anioNacimiento);
        }
        public void Saludar()
        {
            Console.Write("Hola soy {0}", Nombre);
            Console.WriteLine(" y tengo {0}", Edad);
        }
    }
}
