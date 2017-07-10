using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Facultad
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public static List<Facultad> GetFacultad()
        {
            List<Facultad> list = new List<Facultad>();

            list.Add(new Facultad { Nombre = "Facultad de Medicina", Codigo = 1 });
            list.Add(new Facultad { Nombre = "Facultad de Fisicas", Codigo = 2 });
            list.Add(new Facultad { Nombre = "Facultad de Matematicas", Codigo = 3 });

            return list;
        }

        public static int ObtenerIdFacultad(string nombre)
        {
            List<Facultad> lista = GetFacultad();

            foreach (Facultad facultad in lista)
            {
                if (facultad.Nombre == nombre)
                {
                    return facultad.Codigo;
                }
            }

            return 0;
        }
    }
}
