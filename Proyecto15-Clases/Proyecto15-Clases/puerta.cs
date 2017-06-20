using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto15_Clases
{
    public class Puerta
    {
        // modo primario para declarar las variables
        //public int ancho;
        //public int alto;
        //public string color;
        //public bool abierta;

        // get y set: lectura y escriptura
        // 
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public string Color { get; set; }
        public bool Abierta { get; set; }

        public void Abrir()
        {
            Abierta = true;
        }
        public void Cerrar()
        {
            Abierta = false;
        }
        public void MostrarEstado()
        {
            string resultado = (Abierta == true) ? "si" : "no";

            Console.WriteLine("Datos de la puerta\n");
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Alto: {0}", Alto);
            Console.WriteLine("Ancho: {0}", Ancho);
            Console.WriteLine("Abierta: {0}", resultado);
        }
    }
}
