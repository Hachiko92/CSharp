using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerProyectoC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Introduce un número: ");
            //// int primerNumero = Console.ReadLine();
            //// primerNumero es un intero y ReadLine devuelve uno string (lo que lee desde el teclado)
            //// para que sea int hago un conversión (cast)
            //int primerNumero = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Introduce otro número:");
            //int segundoNumero = Convert.ToInt32(Console.ReadLine());

            //int suma = primerNumero + segundoNumero;

            //Console.WriteLine("El primer número era {0}, el segundo era {1} y la suma es {2}", primerNumero, segundoNumero, suma);
            //Console.ReadLine();


            //// segunda parte
            //Console.Write("a: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("b: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //int operacion = (a + b) * (a - b);
            //Console.WriteLine("operacion es: {0}", operacion);
            //int restaCuadrados = (a * a) - (b * b);
            //Console.WriteLine("restaCuadrados es: {0}", restaCuadrados);

            //Console.ReadLine();

            //// tercera parte
            //// tabelline
            //Console.Write("nùmero: ");
            //int numero = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("{0} X {1} es {2}", numero, 1, numero * 1);
            //Console.WriteLine("{0} X {1} es {2}", numero, 2, numero * 2);
            //Console.WriteLine("{0} X {1} es {2}", numero, 3, numero * 3);
            //Console.WriteLine("{0} X {1} es {2}", numero, 4, numero * 4);
            //Console.WriteLine("{0} X {1} es {2}", numero, 5, numero * 5);
            //Console.WriteLine("{0} X {1} es {2}", numero, 6, numero * 6);
            //Console.WriteLine("{0} X {1} es {2}", numero, 7, numero * 7);
            //Console.WriteLine("{0} X {1} es {2}", numero, 8, numero * 8);
            //Console.WriteLine("{0} X {1} es {2}", numero, 9, numero * 9);
            //Console.WriteLine("{0} X {1} es {2}", numero, 10, numero * 10);

            //Console.ReadLine();

            // cuarta parte
            // conversion desde miglias hasta metros
            Console.Write("Millas: ");
            int millas = Convert.ToInt32(Console.ReadLine());
            int metros = millas * Convert.ToInt32(1609.344);

            Console.WriteLine("{0} millas son: {1} metros", millas, metros);

            Console.ReadLine();

            //// cuinta parte
            //// conversion desde celcius a Fahrenheit y Kelvin
            //Console.Write("celsius: ");
            //int celsius = Convert.ToInt32(Console.ReadLine());
            //int fahrenheit = Convert.ToInt32(1.8 * celsius + 32);
            //int kelvin = Convert.ToInt32(celsius + 273.15);

            //Console.WriteLine("{0} Celsius son: {1} Fahrenheit y {2} Kelvin", celsius, fahrenheit, kelvin);

            //Console.ReadLine();
        }
    }
}


