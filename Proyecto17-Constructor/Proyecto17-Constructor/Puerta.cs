using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto17_Constructor
{
    public class Puerta
    {
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public int Grosor { get; set; }
        public string Color { get; set; }
        public bool Abierta { get; set; }

        public Puerta()
        {
            Ancho = 86;
            Alto = 230;
            Grosor = 23;
            Color = "Verde";
            Abierta = true;
        }

        public Puerta (int x, int y)
        {
            Ancho = x;
            Alto = y;
        }

        //public void Abrir()
        //{
        //    Abierta = true;
        //}
        //public void Cerrar()
        //{
        //    Abierta = false;
        //}
        //public void MostrarEstado()
        //{
        //    string resultado = (Abierta == true) ? "si" : "no";

        //    Console.WriteLine("Datos de la puerta\n");
        //    Console.WriteLine("Color: {0}", Color);
        //    Console.WriteLine("Alto: {0}", Alto);
        //    Console.WriteLine("Ancho: {0}", Ancho);
        //    Console.WriteLine("Abierta: {0}", resultado);
        //}
    }
}
