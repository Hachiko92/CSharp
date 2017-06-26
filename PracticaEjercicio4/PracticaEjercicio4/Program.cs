using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaEjercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero leonMufasa = new Mamifero("León", "Mufasa", 190.50D, 11, 5);
            Mamifero leonSarabi = new Mamifero("León", "Sarabi", 127D, 11, 4);
            Mamifero tigreShiva = new Mamifero("Tigre", "Shiva", 303D, 13, 10);
            Ave aguilaEmmet = new Ave("Aguila", "Emmet", 5.1D, 32);

            Console.WriteLine("Animales en lo zoo\n");
            leonMufasa.imprimirDatos();
            leonMufasa.rugir();
            Console.WriteLine("\n------------------------------------------\n");
            leonSarabi.imprimirDatos();
            leonSarabi.rugir();
            Console.WriteLine("\n------------------------------------------\n");
            tigreShiva.imprimirDatos();
            tigreShiva.rugir();
            Console.WriteLine("\n------------------------------------------\n");
            aguilaEmmet.imprimirDatos();
            aguilaEmmet.volar();
            Console.WriteLine("\n------------------------------------------\n");

            Console.ReadKey();
        }
    }
}
