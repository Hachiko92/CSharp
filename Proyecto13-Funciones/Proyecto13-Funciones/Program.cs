using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto13_Funciones
{
    class Program
    {
        public static void saludar()
        {
            Console.WriteLine("Hola mundo!");
        }
        public static void escribeNumeros (float n, int m)
        {
            // así imprime solo la primera cifra decimal
            Console.WriteLine(n.ToString("#.#"));
            Console.WriteLine(m.ToString());
        }
        public static double cuadrado (int n)
        {
            //return (n * n);
            return Math.Pow(n,2);
        }
        public static float mayor(float n1, float n2)
        {
            float result;
            result = (n1 > n2) ? n1 : n2;
            return result;
        }
        public static float cubo(float n)
        {
            return (n * n * n);
        }

        static void Main(string[] args)
        {
            //saludar();
            //escribeNumeros(2.34f, 56);
            //double resultado = cuadrado(4);
            //Console.WriteLine(resultado.ToString());
            //float resultado = mayor(13, 67);
            //Console.WriteLine(resultado.ToString());

            float resultado = cubo(3.2f);
            Console.WriteLine("el cubo de 3,2: {0}", resultado.ToString());
            resultado = cubo(5);
            Console.WriteLine("el cubo de 5: {0}", resultado.ToString());



            Console.ReadLine();
        }
    }
}
