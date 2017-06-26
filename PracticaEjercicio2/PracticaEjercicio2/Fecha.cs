using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaEjercicio2
{
    class Fecha
    {
        #region Atributos
        private int dia { get; set; }
        private int mes { get; set; }
        private int anio { get; set; }

        private string[] meses = { "enero", "febrero", "marzo",
                                   "abril", "mayo", "junio",
                                   "julio", "agosto", "septiembre",
                                   "octubre", "noviembre", "diciembre"};
        #endregion

        #region Constructores
        public Fecha()
        {
            dia = DateTime.Today.Day;
            mes = DateTime.Today.Month;
            anio = DateTime.Today.Year;
        }
        public Fecha(int dia, int mes, int anio)
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }
        #endregion

        #region Métodos
        public void modificarFecha (int dia, int mes, int anio)
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }

        public void imprimir()
        {
            Console.WriteLine("{0}/{1}/{2}", dia, mes, anio);
        }

        public void imprimirMesEscrito()
        {
            Console.WriteLine("{0} de {1} {2}", dia, meses[mes - 1], anio);
        }

        #endregion
    }
}
