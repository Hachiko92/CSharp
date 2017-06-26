using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaEjercicio5
{
    class DosNumeros
    {
        private int primerNumero { get; set; }
        private int segundoNumero { get; set; }

        public DosNumeros()
        {
            primerNumero = segundoNumero = 1;
        }
        public DosNumeros(int numero1, int numero2)
        {
            primerNumero = numero1;
            segundoNumero = numero2;
        }

        public int sumar()
        {
            int resultado = primerNumero + segundoNumero;
            return resultado;
        }

        public int restar()
        {
            int resultado = primerNumero - segundoNumero;
            return resultado;
        }

        public int multiplicar()
        {
            int resultado = primerNumero * segundoNumero;
            return resultado;
        }

        public float dividir()
        {
            float resultado = (float)primerNumero / (float)segundoNumero;
            return resultado;
        }

        public void imprimir()
        {
            Console.WriteLine("Primer numero: {0}", primerNumero);
            Console.WriteLine("Segundo numero: {0}", segundoNumero);
        }
    }
}
