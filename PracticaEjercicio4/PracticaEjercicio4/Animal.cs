using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaEjercicio4
{
    public abstract class Animal
    {
        protected string clase;
        protected string nombre;
        protected double peso;
        protected int jaula;
        protected int edad;

        public Animal(string clase, string nombre, double peso, int jaula)
        {
            this.clase = clase;
            this.nombre = nombre;
            this.peso = peso;
            this.jaula = jaula;
        }

        public virtual void imprimirDatos()
        {
            Console.WriteLine("Clase animal: {0}", clase);
            Console.WriteLine("Nombre animal: {0}", nombre);
            Console.WriteLine("Peso: {0}", peso);
            Console.WriteLine("Jaula: {0}", jaula);
        }
    }
}
