using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto07
{
    class Program
    {
        static void Main(string[] args)
        {
            //float calificacion = 12.5f;
            //// double variableDouble = 12.5d;
            //double variableDouble = 12.5;
            //double promedio = 16.33f;
            //decimal totalPago = 2345.65m;

            // ****** ToSingle ******
            float numero1, numero2, suma;

            Console.Write("Intruce primer numero: ");
            numero1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Intruce segundo numero: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            suma = numero1 + numero2;

            // suma devuelve un número con maximo 4 decimales
            Console.WriteLine("La suma es {0}", suma);
            // suma devuelve un número con 1 decimal (modelo N)
            Console.WriteLine("La suma es {0}", suma.ToString("N1"));
            // suma devuelve un número con 3 decimales
            Console.WriteLine("La suma es {0}", suma.ToString("N3"));
            // suma devuelve un número con 2 decimales (modelo 0)
            Console.WriteLine("La suma es {0}", suma.ToString("00.00"));
            // suma devuelve un número con 3 decimales (modelo #)
            Console.WriteLine("La suma es {0}", suma.ToString("#.###"));

            Console.ReadLine();
        }
    }
}
