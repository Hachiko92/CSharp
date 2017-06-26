using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaEjercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleccion, cuenta = 0;

            Console.WriteLine("Carta hamburguesería\n");
            Console.WriteLine("1 - Hamburguesa sencilla 5 euro");
            Console.WriteLine("2 - Hamburguesa con queso 8 euro");
            Console.WriteLine("3 - Hamburguesa especial 10 euro");
            Console.WriteLine("4 - Patatas frita 3 euro");
            Console.WriteLine("5 - Refresco 2 euro");
            Console.WriteLine("6 - Postre 3 euro");
            Console.WriteLine("0 - Terminar\n");
            try
            {
                do
                {
                    Console.Write("Elije una opcion: ");
                    eleccion = Convert.ToInt32(Console.ReadLine());

                    switch (eleccion)
                    {
                        case 0:
                            break;
                        case 1:
                            cuenta += 5;
                            break;
                        case 2:
                            cuenta += 8;
                            break;
                        case 3:
                            cuenta += 10;
                            break;
                        case 4:
                            cuenta += 3;
                            break;
                        case 5:
                            cuenta += 2;
                            break;
                        case 6:
                            cuenta += 3;
                            break;
                        default:
                            Console.WriteLine("Elección inválida, elije otra vez");
                            break;
                    }

                } while (eleccion != 0);

                Console.WriteLine("\nEl total es: {0}", cuenta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
            
        }
    }
}
