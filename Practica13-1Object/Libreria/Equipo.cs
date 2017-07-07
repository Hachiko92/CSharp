using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Equipo
    {
        public string numSerie { get; set; }
        public string Nombre { get; set; }
        public int Facultad { get; set; }

        public static List<Equipo> GetEquipo()
        {
            List<Equipo> list = new List<Equipo>();

            List<Facultad> listFacultades = Libreria.Facultad.GetFacultad();

            list.Add(new Equipo { Facultad = listFacultades[0].Codigo, Nombre = "Magnetoscopio Bascular", numSerie = "A233" });
            list.Add(new Equipo { Facultad = listFacultades[0].Codigo, Nombre = "Condesador de Particulas", numSerie = "F356" });
            list.Add(new Equipo { Facultad = listFacultades[1].Codigo, Nombre = "Super Ordenador", numSerie = "P934" });
            list.Add(new Equipo { Facultad = listFacultades[2].Codigo, Nombre = "Ionizador Atómico", numSerie = "I843" });

            return list;
        }
    }
}
