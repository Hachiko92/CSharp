using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto15_Clases
{
    // Porton ereda de Puerta
    public class Porton : Puerta
    {
        public bool Bloqueado { get; set; }

        public void Bloquear()
        {
            Bloqueado = true;
        }
        public void Desbloquear()
        {
            Bloqueado = false;
        }

        // como ya esiste el metodo en Puerta pero no me vale por esto elemento
        // lo defino otra vez utilizando "new"
        public new void MostrarEstado()
        {
            string abierta = (Abierta == true) ? "si" : "no";
            string bloqueado = (Bloqueado == true) ? "si" : "no";

            Console.WriteLine("Datos de la puerta\n");
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Alto: {0}", Alto);
            Console.WriteLine("Ancho: {0}", Ancho);
            Console.WriteLine("Abierta: {0}", abierta);
            Console.WriteLine("Bloqueado: {0}", bloqueado);
        }
    }
}
