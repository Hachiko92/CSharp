using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto02_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero;

            //Console.Write("Introduce nùmero: ");
            //numero = Convert.ToInt32(Console.ReadLine());

            //if(numero > 5)
            //{
            //    Console.WriteLine("El número es mayor de 5");
            //}
            //else
            //{
            //    Console.WriteLine("El número es menor o igual que 5");
            //}

            //int numero;

            //Console.Write("Introduce nùmero: ");
            //numero = Convert.ToInt32(Console.ReadLine());

            //if (!(numero < 5) && (numero < 9))
            //{
            //    Console.WriteLine("El número es mayor o igual a 5 y menor de 9");
            //}
            //else
            //{
            //    Console.WriteLine("El número es menorque 5 o mayor o igual que 9");
            //}


            //// Ejercicio 1.13 - El mayor entre 3 numeros
            //int numero1, numero2, numero3;

            //Console.WriteLine("El mayor de tres numeros");
            //Console.Write("Introduce el primer nùmero: ");
            //numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Introduce el segundo nùmero: ");
            //numero2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Introduce el tercer nùmero: ");
            //numero3 = Convert.ToInt32(Console.ReadLine());

            //if ((numero1 > numero2) && (numero1 > numero3))
            //{
            //    Console.WriteLine("El mayor es el primer número: {0}", numero1);
            //}
            //else
            //{
            //    if ((numero2 > numero1) && (numero2 > numero3))
            //    {
            //        Console.WriteLine("El mayor es el segundo número: {0}", numero2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("El mayor es el tercer número: {0}", numero3);
            //    }
            //}

            //Console.ReadLine();

            //// Ejercicio 1.14 - averguar si los dos numero son iguales si no cual es el mayor
            //int numero1, numero2;

            //Console.WriteLine("El mayor de tres numeros");
            //Console.Write("Introduce el primer nùmero: ");
            //numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Introduce el segundo nùmero: ");
            //numero2 = Convert.ToInt32(Console.ReadLine());

            //if (numero1 == numero2)
            //{
            //    Console.WriteLine("Los dos números son iguales");
            //}
            //else
            //{
            //    if (numero1 > numero2)
            //    {
            //        Console.WriteLine("El mayor es el primer número: {0}", numero1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("El mayor es el segundo número: {0}", numero2);
            //    }
            //}

            //Console.ReadLine();

            // Ejercicio 1.15 - valor absoluto de un numero
            int numero;

            Console.WriteLine("Valor absoluto");
            Console.Write("Introduce el numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            int resultado = (numero >= 0) ? numero : -numero;

            Console.WriteLine("Resultado: {0}", resultado);

            Console.ReadLine();
        }
    }
}
