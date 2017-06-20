using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto19_Concatena
{
    class Concatena
    {
        private string nombre;
        private string apellido;

        public Concatena (string nomb, string apell)
        {
            this.nombre = nomb;
            this.apellido = apell;
        }

        public string concatenar()
        {
            return this.nombre + " " + this.apellido;
        }
    }
}
