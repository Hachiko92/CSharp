using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PracticaEjercicio2
{
    public class Fecha
    {
        private int dia { get; set; }
        private int mes { get; set; }
        private int anio { get; set; }

        public Fecha()
        {
            dia = DateTime.Today.Day;
            mes = DateTime.Today.Month;
            anio = DateTime.Today.Year;
        }

        public Fecha(int day, int month, int year)
        {
            // hacer controles
            dia = day;
            mes = month;
            anio = anio;
        }

        public void modificar(int day, int month, int year)
        {
            // hacer controles
            dia = day;
            mes = month;
            anio = anio;
        }

        public void mostrar()
        {
            Console.WriteLine("{0}/{1}/{2}", dia, mes, anio);
        }

        public void mostrarMesIntero()
        {
            string month;
            switch (mes)
            {
                case 0:
                    month = "enero";
                    break;
                case 1:
                    month = "febrero";
                    break;
                case 2:
                    month = "marzo";
                    break;
                case 3:
                    month = "abril";
                    break;
                case 4:
                    month = "mayo";
                    break;
                case 5:
                    month = "junio";
                    break;
                case 6:
                    month = "julio";
                    break;
                case 7:
                    month = "agosto";
                    break;
                case 8:
                    month = "septiembre";
                    break;
                case 9:
                    month = "octubre";
                    break;
                case 10:
                    month = "noviembre";
                    break;
                case 11:
                    month = "deciembre";
                    break;
                default:
                    Console.WriteLine("Formato més invalido");
                    return;
            }

            Console.WriteLine("{0} de {1} del{2}", dia, month, anio);


        }

    }
}
