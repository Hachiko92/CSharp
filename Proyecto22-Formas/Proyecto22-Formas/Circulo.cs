using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22_Formas
{
    public class Circulo : Formas
    {
        public Circulo(double radio) : base(radio, 0)
        {

        }

        public override double Area()
        {
            // x es el radio 
            return (pi * x * x);
        }
    }
}
