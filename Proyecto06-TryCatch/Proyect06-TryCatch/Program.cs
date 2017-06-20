using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto06_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //// ******** Ejemplo 1 ********
            //int numero1, numero2, resultado;

            //try
            //{
            //    Console.WriteLine("División");
            //    Console.Write("Primer numero: ");
            //    numero1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Segundo numero: ");
            //    numero2 = Convert.ToInt32(Console.ReadLine());
            //    resultado = numero1 / numero2;
            //    Console.WriteLine("El resultado es: {0}", resultado);
            //    Console.ReadLine();
            //}
            //catch (Exception errorEncontrado)
            //{
            //    Console.WriteLine("Ha habido un error: {0}", errorEncontrado.Message);
            //    Console.ReadLine();
            //}

            //// ******** Ejemplo 2 ********
            //int numero1, numero2, resultado;

            //try
            //{
            //    Console.WriteLine("División");
            //    Console.Write("Primer numero: ");
            //    numero1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Segundo numero: ");
            //    numero2 = Convert.ToInt32(Console.ReadLine());
            //    resultado = numero1 / numero2;
            //    Console.WriteLine("El resultado es: {0}", resultado);
            //    Console.ReadLine();
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("No es un formato correcto");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Intento de dividir por 0");
            //}

            // ******** Ejemplo 3 ********
            // Pedir año de nachimiento a el usuario y controlar si es valido

            try
            {

                Console.Write("Edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception error)
            {
                Console.WriteLine("Ha habido un error en la edad: {0}", error.Message);
            }

            Console.Write("Año de nacimiento: ");
            int anio = Convert.ToInt32(Console.ReadLine());

        }
    }
}
