using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, anio;

            try
            {
                Console.WriteLine("Insertar fecha");
                Console.Write("Dia: ");
                dia = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mes: ");
                mes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Año: ");
                anio = Convert.ToInt32(Console.ReadLine());

                Fecha hoy = new Fecha();
                Fecha personal = new Fecha(dia, mes, anio);
                /* validaccion fecha */
                DateTime data = new DateTime(anio, mes, dia);
                
                Console.Write("\nLa primer fecha es: ");
                hoy.imprimir();
                Console.Write("La segunda fecha es: ");
                personal.imprimir();

                Console.WriteLine("\nCambiar la primer fecha:");
                Console.Write("Dia: ");
                dia = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mes: ");
                mes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Año: ");
                anio = Convert.ToInt32(Console.ReadLine());
                /* validaccion fecha */
                data = new DateTime(anio, mes, dia);
                hoy.modificarFecha(dia, mes, anio);

                Console.Write("\nLa primer fecha es: ");
                hoy.imprimirMesEscrito();
                Console.Write("La segunda fecha es: ");
                personal.imprimirMesEscrito();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
