using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto11_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ejemplo = "Pepe,Jose,Ivan,Eva";
            //string[] nombres = ejemplo.Split(',');

            //for (byte i = 0; i < nombres.Length; i++)
            //{
            //    Console.WriteLine("{0}: {1}", (i + 1), nombres[i]);
            //}

            //Console.ReadLine();

            // Ejercicio 1.22

            Console.WriteLine("Escribe numeros separados por un espacio");
            string numeros = Console.ReadLine();

            string[] sNumeros = numeros.Split(' ');
            int suma = 0;

            for(int i=0; i< sNumeros.Length; i++)
            {
                suma += Convert.ToInt32(sNumeros[i]);
            }

            Console.WriteLine("La suma es: {0}", suma);

            Console.ReadLine();
        }
    }
}
