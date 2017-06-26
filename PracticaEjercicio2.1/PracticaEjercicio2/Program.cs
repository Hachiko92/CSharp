using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, anio;

            Console.WriteLine("Insertar la fecha");
            Console.Write("Día: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Més: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Año: ");
            anio = Convert.ToInt32(Console.ReadLine());

            Fecha hoy = new Fecha();
            Fecha usuario = new Fecha(dia, mes, anio);

            Console.WriteLine("La fecha de hoy es: ");
            hoy.mostrar();

            Console.WriteLine("\nLa fecha que has insertado es:");
            usuario.mostrar();
        }
    }
}
