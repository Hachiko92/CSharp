using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto22_Formas
{
    public abstract class Formas
    {
        public const double pi = Math.PI;
        protected double x, y;

        public Formas(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        // tiene que ser abstract como la clase en la cual está contenida
        // aquí solo es definida, sus clases derivadas debrán si o si declararla
        public abstract double Area();
    }
}
