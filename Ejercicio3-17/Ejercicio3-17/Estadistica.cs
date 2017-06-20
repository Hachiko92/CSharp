using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_17
{
    public class Estadistica
    {
        private int numero1, numero2, numero3;

        public Estadistica(int n1, int n2, int n3)
        {
            numero1 = n1;
            numero2 = n2;
            numero3 = n3;
        }

        public int suma()
        {
            return (numero1 + numero2 + numero3);
        }

        public decimal media()
        {
            return (suma() / 3);
        }
    }
}
