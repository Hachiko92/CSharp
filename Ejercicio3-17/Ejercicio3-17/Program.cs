using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Primer número: ");
            int nu1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo número: ");
            int nu2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tercer número: ");
            int nu3 = Convert.ToInt32(Console.ReadLine());

            //string num3 = (Console.ReadLine());
            //nu3 = int.Parse(num3);

            Estadistica esta = new Estadistica(nu1, nu2, nu3);

            string suma = esta.suma().ToString(), media = esta.media().ToString();

            Console.WriteLine("\nLa suma es: {0}", suma);
            Console.WriteLine("La media es: {0}", media);

            Console.ReadLine();
        }
    }
}
