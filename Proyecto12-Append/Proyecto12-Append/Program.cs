using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto12_Append
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder cadenaConstruida = new StringBuilder();

            cadenaConstruida.Append("\"Cadena primera\" ");
            cadenaConstruida.Append("\"Cadena segunda\" ");
            cadenaConstruida.Append("\"Cadena tercera\" ");

            Console.WriteLine("{0}", cadenaConstruida);

            string cadenaNormal = "esta es normal";

            // string y stringBuilder son dos tipos diferentes y no se pueden juntar en cadenaConstruida
            // cadenaConstruida = cadenaConstruida + cadenaNormal;

            string cadenaFianl = cadenaConstruida.ToString() + cadenaNormal;

            Console.ReadLine();
        }
    }
}
