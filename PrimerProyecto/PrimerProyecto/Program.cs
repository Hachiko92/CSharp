// System, System.Collections.Generic, etc. son libros de la libreria .NET
// Generic es hija de Collections que es hija de System (estan utilizando herencias)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// es como crear otro libro de añadir a la libreria que ya tenemos
namespace PrimerProyecto
{
    // La clase me crea un objeto 
    class Program
    {
        // static porque no necesito hacer un estancia del Main
        // void porque no devuelve nada
        static void Main(string[] args)
        {
            // System.Console.ForegroundColor = System.ConsoleColor.Green;
            // no hace falta poner el System adelante
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Introduce tu nombre:");
            Console.ReadLine();
            Console.Write("Nº de credencial: ");
            Console.ReadLine();
            Console.Write("Acceso Permitido");
            Console.ReadLine();


            //// WriteLine es un metodo
            //// WriteLine escribe en un Linea y se pasa a la siguente linea
            //Console.WriteLine("Hola Mundo!");

            //// si no se pone ReadLine no se para el program (se cierra sola la consola)
            //Console.ReadLine();
        }
    }
}

