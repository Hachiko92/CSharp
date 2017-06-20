using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto10_Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabraCompleta = "Esta es una variable de cadena";
            string cadenaMayuscula = palabraCompleta.ToUpper();
            string cadenaMinuscula = palabraCompleta.ToLower();

            Console.WriteLine("{0}\n{1}\n{2}\n", palabraCompleta, cadenaMayuscula, cadenaMinuscula);

            // 5 es la posicion
            string cadenaInsertada = palabraCompleta.Insert(5, "algo de fuera ");
            Console.WriteLine("{0}", cadenaInsertada);

            string cadenaBorrada = cadenaInsertada.Remove(5, 14);
            Console.WriteLine("{0}", cadenaBorrada);

            string cadenaReemplazada = palabraCompleta.Replace(" es ", " uno ");
            Console.WriteLine("{0}", cadenaReemplazada);

            Console.ReadLine();
        }
    }
}
