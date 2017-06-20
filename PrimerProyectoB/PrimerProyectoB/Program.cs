using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoB
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = 3, segundoNumero = 4;
            //Console.WriteLine(primerNumero + segundoNumero);

            int suma = primerNumero + segundoNumero;

            // despues el texto separado por una comma es como si se crea un array
            // en lo cual accedo a traves de {}
            Console.WriteLine("El valor de la suma es {0} de {1} mas {2}", suma, primerNumero, segundoNumero);
            Console.ReadLine();
        }
    }
}