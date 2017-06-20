using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22_Formas
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 2.5;
            double height = 3.0;

            Circulo ring = new Circulo(radius);
            Cilindro tube = new Cilindro(radius, height);

            // {0:F2} el double serà visualizado con solo dos decimales
            Console.WriteLine("Area del circulo: {0:F2}", ring.Area());
            Console.WriteLine("Area del cilindro: {0:F2}", tube.Area());

            Console.ReadKey();

        }
    }
}
