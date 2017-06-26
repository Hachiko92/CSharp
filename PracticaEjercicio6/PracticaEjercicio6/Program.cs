using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PracticaEjercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroJugadores = 3, iNombres = 0, iMasas = 0;
            string nombre, linea;
            string[] nombres, masas;
            nombres = new string[numeroJugadores];
            masas = new string[numeroJugadores];
            float peso, altura, masaCorporal;

            /* inicializados a null para poderlos utilizar en "finally",
             * para asegurarse que los ficheros se cierren aunque pase algun error */
            StreamWriter fichero = null;
            StreamReader ficheroRead = null;

            try
            {
                /* Recuperar las informaciones de los jugadores y cargarlos en un fichero */
                fichero = File.CreateText("jugadoresRugby.txt");

                Console.WriteLine("Insertar los datos de los tres jugadores");

                for (int i = 0; i < numeroJugadores; i++)
                {
                    Console.WriteLine("\nJugador {0}", (i + 1));
                    fichero.WriteLine("\nJugador {0}", (i + 1));

                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    fichero.WriteLine("Nombre: {0}", nombre);

                    Console.Write("Peso: ");
                    peso = float.Parse(Console.ReadLine());
                    fichero.WriteLine("Peso: {0}", peso);

                    Console.Write("Altura: ");
                    altura = float.Parse(Console.ReadLine());
                    fichero.WriteLine("Altura: {0}", altura);

                    masaCorporal = (peso / (altura * altura));
                    fichero.WriteLine("Masa corporal: {0}\n", masaCorporal);

                }

                fichero.Close();

                /* Lee el fichero de los jugadores y almacena los datos que necesita */
                ficheroRead = File.OpenText("jugadoresRugby.txt");

                do
                {
                    linea = ficheroRead.ReadLine();
                    if (linea != null)
                    {
                        if (linea.Contains("Nombre"))
                        {
                            linea = linea.Remove(0, 8);
                            nombres[iNombres] = linea;
                            iNombres++;
                        }
                        else
                        {
                            if (linea.Contains("Masa"))
                            {
                                linea = linea.Remove(0, 15);
                                masas[iMasas] = linea;
                                iMasas++;
                            }
                        }
                    }
                } while (linea != null);

                ficheroRead.Close();

                /* Imprime los datos almacenados */
                if (nombres.Length == masas.Length)
                {
                    Console.WriteLine("\nJugadores\n");
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        Console.WriteLine("Nombre: {0}",nombres[i]);
                        Console.WriteLine("Masa corporal: {0}\n", masas[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Error en los datos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fichero.Close();
                ficheroRead.Close();
            }
            
            Console.ReadKey();
        }
    }
}
