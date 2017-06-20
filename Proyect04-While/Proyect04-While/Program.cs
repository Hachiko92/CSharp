using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect04_While
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1.17 - 
            int i = 0, control = 1, numeroUtente;
            const int numero = 13;
            while(control != 0)
            {

                Console.WriteLine("adivine el numero (1-20) en 3 tentativos: ");

                while(i < 3)
                {
                    Console.WriteLine("Tentativo numero: {0}", i + 1);
                    Console.Write("Tecla un numero: ");
                    numeroUtente = Convert.ToInt32(Console.ReadLine());
                    
                    if (numeroUtente == numero)
                    {
                        Console.WriteLine("Esacto!");
                        i = 10;
                    }
                    else
                    {
                        if ((numeroUtente < 1) || (numeroUtente > 20))
                        {
                            Console.WriteLine("El numero está entre 1 y 20");
                        }
                        else
                        {

                            if (numeroUtente > numero)
                            {
                                Console.WriteLine("mi numero es minor");
                            }
                            else
                            {
                                Console.WriteLine("mi numero es mayor");
                            }
                        }

                        i++;
                    }
             
                }

                if (i == 10)
                {
                    Console.WriteLine("Bravo! El numero es: {0}", numero);
                }
                else
                {
                    Console.WriteLine("Tendras más suerte la proxima vez!");
                }
                Console.Write("Quieres jugar otra vez? (numero positivo: ok, 0: salir): ");
                control = Convert.ToInt32(Console.ReadLine());
                i = 0;
            }

        }
    }
}