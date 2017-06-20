using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto17_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // cualquier tipo de clase por defecto tiene un metodo constructor 
            Puerta p1 = new Puerta();
            Puerta p2 = new Puerta(90, 230);
        }
    }
}
