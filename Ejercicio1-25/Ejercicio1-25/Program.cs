using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_25
{
    class Program
    {
        struct fichero
        {
            public string nombre;
            public ulong tamanio;
        }
        static void Main(string[] args)
        {
            // cantitad se refiere a los ficheros ya almacenados
            byte opcion = 0;
            ushort cantidad = 0, capacidad = 1000;
            // las necesitos para varias operaciones por varios cases en lo switch
            string nombre;
            ulong tamanio;

            // Ejercicio 1.25
            fichero[] ficheros = new fichero[capacidad];
            
            Console.WriteLine("OPCIONES\n");
            Console.WriteLine("1.Añadir nuevo fichero");
            Console.WriteLine("2.Mostrar ficheros almacenados");
            Console.WriteLine("3.Mostrar ficheros con un tamaño specifico minimo");
            Console.WriteLine("4.Buscar un fichero por nombre");
            Console.WriteLine("5.Salir");

            do
            {
                Console.Write("\nElije opción: ");
                try
                {
                    opcion = Convert.ToByte(Console.ReadLine());
                    if ((opcion > 5) && (opcion < 1))
                    {
                        throw new ArgumentException("Fuera del intervalo (1-5)");
                    }
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                    Console.ReadLine();
                    continue;
                }
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\nNuevo fichero");
                        if(cantidad == capacidad)
                        {
                            Console.WriteLine("Los ficheros no pueden ser mas de 1000");
                        }
                        else
                        {
                            Console.Write("Introduce el nombre del fichero: ");
                            nombre = Console.ReadLine();
                            Console.Write("Introduce el tamaño en KB del fichero: ");
                            tamanio = Convert.ToUInt64(Console.ReadLine());
                            if(tamanio > 8000000000)
                            {
                                Console.WriteLine("El tamaño es demasiado grande (maximo 8000000000), el elemento no será añadido.");
                            }
                            else
                            {
                                ficheros[cantidad].nombre = nombre;
                                ficheros[cantidad].tamanio = tamanio;
                                cantidad++;
                            }
                        }
                        break;

                    case 2:
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("fichero {0}: {1} de {2}kb", (i + 1), ficheros[i].nombre, ficheros[i].tamanio);
                        }
                        //foreach (fichero file in ficheros)
                        //{
                        //    if (file.nombre != null)
                        //    {
                        //        Console.WriteLine("{1} de {2}KB", file.nombre, file.tamanio);
                        //    }
                        //}
                        break;
                    case 3:
                        Console.Write("Escribe el tamaño minimo de los ficheros que buscas: ");
                        ulong dimension = Convert.ToUInt64(Console.ReadLine());
                        for (int i = 0; i < cantidad; i++)
                        {   
                            if(ficheros[i].tamanio >= dimension)
                            {
                                Console.WriteLine("fichero {0}: {1} de {2}KB", (i + 1), ficheros[i].nombre, ficheros[i].tamanio);
                            }
                        }
                        break;
                    case 4:
                        Console.Write("Que fichero buscas? ");
                        nombre = Console.ReadLine();
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (ficheros[i].nombre == nombre)
                            {
                                Console.WriteLine("fichero {0}: {1} de {2}KB", (i + 1), ficheros[i].nombre, ficheros[i].tamanio);
                                break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Fuera de intervalo");
                        break;
                }
            } while (opcion != 5);
        }
    }
}
