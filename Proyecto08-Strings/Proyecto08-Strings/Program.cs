using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto08_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //// String
            //string frase = "Hola Mundo";
            //Console.WriteLine("La frase es: \"{0}\"\n", frase);

            //Console.Write("Introduce una frase: ");
            //frase = Console.ReadLine();

            //Console.WriteLine("\nLa frase es: \"{0}\"", frase);
            //Console.WriteLine("Hola {0}", frase);

            //Console.ReadLine();

            //// Boolean
            //bool encontrado, partidaTerminada;
            //int nivel, ultimoNivel, enemigos, vidas;
            //nivel = ultimoNivel = enemigos = 0;
            //vidas = 3;

            //partidaTerminada = ((enemigos == 0) && (nivel == ultimoNivel));


            //if (vidas == 0)
            //{
            //    partidaTerminada = true;
            //}

            //// Array
            //int[] numeros = new int[4];
            //int[] numeri = { 1, 2, 3, 4 };
            //int suma;

            //numeros[0] = 1;
            //numeros[1] = 2;
            //numeros[2] = 3;
            //numeros[3] = 4;

            //suma = numeros[0] + numeros[1];

            //Console.WriteLine("Suma es: {0}", suma);
            //Console.ReadLine();

            //// For
            //int[] numeros = { 1, 2, 3, 4 };
            //int suma = 0;

            //for (int i=0; i<4; i++)
            //{
            //    suma += numeros[i];
            //}

            //Console.WriteLine("Suma es: {0}", suma);
            //Console.ReadLine();

            //// For 2
            //int[] numeros = new int[4];

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write("Introduce nº en la posición {0}: ", i + 1);
            //    numeros[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.ReadLine();

            // Ejercicio 1.20
            string[] nombres = new String[5];
            string nombre;
            // cantitad son los nombres guardados
            byte cantidad = 0, capacidad = 5, opcion = 0, posicion;

            Console.WriteLine("OPCIONES\n");
            Console.WriteLine("1.Añadir nombre");
            Console.WriteLine("2.Insertar nombre en una determinata posición");
            Console.WriteLine("3.Borrar nombre en una determinata posición");
            Console.WriteLine("4.Mostrar nombres");
            Console.WriteLine("5.Salir");

            while(opcion != 5)
            {
                Console.Write("\nElije opción: ");
                opcion = Convert.ToByte(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce nombre: ");
                        nombre = Console.ReadLine();
                        nombres[cantidad] = nombre;
                        cantidad++;
                        break;
                    case 2:
                        Console.Write("Introduce nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Introduce la posición: ");
                        posicion = Convert.ToByte(Console.ReadLine());
                        if(cantidad < capacidad)
                        {
                            Console.WriteLine("Insertando {0} en la posición {1}", nombre, posicion);
                            for (int i = cantidad; i > (posicion - 1); i--)
                            {
                                nombres[i] = nombres[i - 1];
                            }
                            nombres[posicion - 1] = nombre;
                        }
                        cantidad++;
                        break;
                    case 3:
                        Console.Write("Introduce posición a borrar: ");
                        posicion = Convert.ToByte(Console.ReadLine());
                        for (int i = (posicion - 1); i < cantidad; i++)
                        {
                            nombres[i] = nombres[i + 1];
                        }
                        cantidad--;
                        break;
                    case 4:
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("{0}: {1}", (i + 1), nombres[i]);
                        }
                        break;
                    default:
                        Console.WriteLine("Fuera de intervalo");
                        break;
                }
            }
        }
    }
}
