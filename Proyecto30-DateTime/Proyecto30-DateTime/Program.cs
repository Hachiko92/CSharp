using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto30_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaActual = DateTime.Now;

            Console.WriteLine(fechaActual.Day);

            DateTime fechaNacimiento = new DateTime(1992, 12, 18);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            Console.WriteLine(fechaNacimiento.ToShortDateString());

            TimeSpan diferencia = fechaActual - fechaNacimiento;

            Console.WriteLine(diferencia.TotalDays);
            Console.WriteLine(diferencia.TotalHours);

            Console.ReadKey();
        }
    }
}
