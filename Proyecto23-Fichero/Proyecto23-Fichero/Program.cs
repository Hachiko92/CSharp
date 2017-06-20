using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto23_Fichero
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter fichero;

            //// File gestiona los ficheros individuales
            //fichero = File.CreateText("prueba.txt");

            //fichero.WriteLine("Esta es la primera linea del fichero");
            //fichero.Write("Esto es otra");
            //fichero.WriteLine(" continuación del fichero");

            //fichero.Close();


            //// ************ Ejercicio 5.1 ************
            //StreamWriter ficheroUtente;
            //string frase;

            //ficheroUtente = File.CreateText("ficheroUtente.txt");

            //Console.WriteLine("Escribe lo que quieres poner en el fichero, con la palabra \"fin\" puedes cierrar la app");
            //do
            //{
            //    Console.WriteLine("\nEscribe lo que quieres inserir:");
            //    frase = Console.ReadLine();

            //    if (frase.ToLower() != "fin")
            //    {
            //        ficheroUtente.WriteLine(frase);
            //    }

            //} while (frase.ToLower() != "fin");

            //ficheroUtente.Close();
            //// ************ Fin ejercicio 5.1 ************ 

            //StreamReader fichero;
            //string linea;

            //fichero = File.OpenText("ficheroUtente.txt");

            //do
            //{
            //    linea = fichero.ReadLine();
            //    if (linea != null)
            //    {
            //        Console.WriteLine(linea);
            //    }

            //} while (linea != null);

            //Console.ReadKey();
            //fichero.Close();

            //// ************ Ejercicio 5.3 ************
            //StreamWriter ficheroFrases;
            //string frase;

            //ficheroFrases = File.CreateText("frases.txt");

            //Console.WriteLine("Escribe lo que quieres poner en el fichero, con la palabra \"fin\" puedes cierrar la app");
            //do
            //{
            //    Console.WriteLine("\nEscribe lo que quieres inserir:");
            //    frase = Console.ReadLine();

            //    if (frase.ToLower() != "")
            //    {
            //        ficheroFrases.WriteLine(frase);
            //    }

            //} while (frase.ToLower() != "");

            //ficheroFrases.Close();
            //StreamReader ficheroRead;

            //ficheroRead = File.OpenText("frases.txt");

            //do
            //{
            //    frase = ficheroRead.ReadLine();
            //    if (frase != null)
            //    {
            //        Console.WriteLine(frase);
            //    }

            //} while (frase != null);

            //Console.ReadKey();

            //ficheroRead.Close();
            //// ************ Fin Ejercicio 5.3 ************


            // appendText
            StreamWriter ficheroFrases;
            string frase;
            
            ficheroFrases = File.AppendText("frases.txt");
            ficheroFrases.WriteLine("\nUna linea más!");

            ficheroFrases.Close();

            StreamReader ficheroRead;

            ficheroRead = File.OpenText("frases.txt");
            do
            {
                frase = ficheroRead.ReadLine();
                if (frase != null)
                {
                    Console.WriteLine(frase);
                }

            } while (frase != null);

            Console.ReadKey();

            ficheroRead.Close();

        }
    }
}
