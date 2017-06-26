using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEjercicio1
{
    public class Circunferencia
    {
        private double radio { get; set; }

        public Circunferencia()
        {
            this.radio = 1;
        }

        public Circunferencia(double radio)
        {
            this.radio = radio;
        }

        public double area()
        {
            double resultado = (radio * radio) * Math.PI;
            return resultado;
        }

        public double perimetro()
        {
            double resultado = radio * Math.PI;
            return resultado;
        }

        public void modificarRadio(double radio)
        {
            this.radio = radio;
        }

        public double visualizarRadio()
        {
            return this.radio;
        }
    }
}
