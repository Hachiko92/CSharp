using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaEjercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int primerNumero, segundoNumero, eleccion, resultado;
            float resultadoFloat;

            primerNumero = random.Next(10, 20);
            segundoNumero = random.Next(1, 10);

            DosNumeros numeros = new DosNumeros(primerNumero, segundoNumero);

            Console.WriteLine("Se han generato los siguentes numeros: {0} y {1}", primerNumero, segundoNumero);
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Ver los numeros");
            Console.WriteLine("0 - Salir\n");
            try
            {
                do
                {
                    Console.Write("Elije una opciòn: ");
                    eleccion = Convert.ToInt32(Console.ReadLine());
                    switch (eleccion)
                    {
                        case 0:
                            break;
                        case 1:
                            resultado = numeros.sumar();
                            Console.WriteLine("El resultado es: {0}\n", resultado);
                            break;
                        case 2:
                            resultado = numeros.restar();
                            Console.WriteLine("El resultado es: {0}\n", resultado);
                            break;
                        case 3:
                            resultado = numeros.multiplicar();
                            Console.WriteLine("El resultado es: {0}\n", resultado);
                            break;
                        case 4:
                            resultadoFloat = numeros.dividir();
                            Console.WriteLine("El resultado es: {0:F2}\n", resultadoFloat);
                            break;
                        case 5:
                            numeros.imprimir();
                            Console.Write("\n");
                            break;
                        default:
                            Console.WriteLine("Elección inválida\n");
                            break;
                    }
                } while (eleccion != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\nFin");

            Console.ReadKey();
        }
    }
}
