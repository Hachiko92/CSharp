using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaEjercicio4
{
    public class Mamifero : Animal
    {
        public Mamifero(string clase, string nombre, double peso, int jaula, int edad) : base(clase, nombre, peso, jaula)
        {
            base.edad = edad;
        }

        public new void imprimirDatos()
        {
            base.imprimirDatos();
            Console.WriteLine("Edad: {0}", edad);
        }

        public void rugir()
        {
            Console.WriteLine("Estoy rugiendo");
        }
    }
}
