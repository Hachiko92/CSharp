using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto18
{
    public class Empleado
    {
        public string Nombre { get; set; }
        const int sueldo = 1500;

        public void imprimir(string nombr)
        {
            this.Nombre = nombr;
            Console.WriteLine(this.Nombre);
        }
    }
}
