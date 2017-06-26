using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEjercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radioRueda = 10.2D;
            double radioMoneda = 1.4D;

            Circunferencia rueda = new Circunferencia(radioRueda);
            Circunferencia moneda = new Circunferencia(radioMoneda);

            Console.WriteLine("Inicializada la rueda con radio igual a {0}", radioRueda);
            Console.WriteLine("Inicializada la moneda con radio igual a {0}\n", radioMoneda);

            double areaRueda = rueda.area();
            double areaMoneda = moneda.area();

            Console.WriteLine("El area de la rueda es: {0:F2}", areaRueda);
            Console.WriteLine("El area de la moneda es: {0:F2}\n", areaMoneda);

            double perimetroRueda = rueda.perimetro();
            double perimetroMoneda = moneda.perimetro();

            Console.WriteLine("El perimetro de la rueda es: {0:F2}", perimetroRueda);
            Console.WriteLine("El perimetro de la moneda es: {0:F2}\n", perimetroMoneda);

            Console.ReadKey();
        }
    }
}
