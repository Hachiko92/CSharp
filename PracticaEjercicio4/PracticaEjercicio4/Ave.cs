using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaEjercicio4
{
    class Ave : Animal
    {
        public Ave(string clase, string nombre, double peso, int jaula) : base(clase, nombre, peso, jaula)
        {

        }

        public void volar()
        {
            Console.WriteLine("Estoy volando");
        }
    }
}
