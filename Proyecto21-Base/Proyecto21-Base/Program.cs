using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto21_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordenadas punto1 = new Coordenadas();
            Coordenadas punto2 = new Coordenadas(5, 3);

            Console.WriteLine("Coordenadas de punto1: {0}", punto1);
            Console.WriteLine("Coordenadas de punto2: {0}", punto2);

            Console.ReadKey();
        }
    }
}
