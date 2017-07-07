using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Investigador
    {
        public string DNI { get; set; }
        public string NombreApellido { get; set; }
        public int Facultad { get; set; }

        public static List<Investigador> getInvestigador()
        {
            List<Investigador> list = new List<Investigador>();

            List<Facultad> listFacultades = Libreria.Facultad.GetFacultad();

            list.Add(new Investigador { DNI = "456784L", Facultad = listFacultades[0].Codigo, NombreApellido = "Elena Alvarez" });
            list.Add(new Investigador { DNI = "746894P", Facultad = listFacultades[1].Codigo, NombreApellido = "Pepe Perez" });
            list.Add(new Investigador { DNI = "431698H", Facultad = listFacultades[0].Codigo, NombreApellido = "Pablo Sanchez" });
            list.Add(new Investigador { DNI = "283719R", Facultad = listFacultades[1].Codigo, NombreApellido = "Andrés Desigual" });
            list.Add(new Investigador { DNI = "129482L", Facultad = listFacultades[1].Codigo, NombreApellido = "Marco Rossi" });
            list.Add(new Investigador { DNI = "923198E", Facultad = listFacultades[2].Codigo, NombreApellido = "Nieves González" });

            return list;
        }
    }
}
