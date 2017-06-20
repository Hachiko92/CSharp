using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto13b_NumerosAletorios
{
    class Program
    {
        static void Main(string[] args)
        {
            byte oportunidades = 0;
            Random generador = new Random();
            int numero, aleatorio = generador.Next(1, 100);
            byte opcion = 1;

            Console.Write("Adivina un numero (1-100)");

            do
            {
                Console.Write("\nTienes seis tentativos\n");

                while (oportunidades < 6)
                {
                    Console.Write("Numero: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    if (numero == aleatorio)
                    {
                        Console.WriteLine("Acertaste");
                        oportunidades = 6;
                    }
                    else
                    {
                        if (numero > aleatorio)
                        {
                            Console.WriteLine("Demasiado Alto\n");
                        }
                        else
                        {
                            Console.WriteLine("Demasiado bajo\n");
                        }
                        oportunidades++;
                    }
                }

                Console.Write("Quieres Probar otra vez? escribe 1");
                opcion = Convert.ToByte(Console.ReadLine());
            } while (opcion == 1);
        }
    }
}
