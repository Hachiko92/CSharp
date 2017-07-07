using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Reserva
    {
        public string DNI { get; set; }
        public string NumSerie { get; set; }
        public DateTime Comienzo { get; set; }
        public DateTime Fin { get; set; }

        public static List<Reserva> getReserva()
        {
            List<Reserva> list = new List<Reserva>();

            List<Investigador> listInvestigadores = Libreria.Investigador.getInvestigador();
            List<Equipo> listEquipos = Libreria.Equipo.GetEquipo();

            list.Add(new Reserva { DNI = listInvestigadores[0].DNI, NumSerie = listEquipos[1].numSerie, Comienzo = DateTime.Parse("2017/06/23"), Fin = DateTime.Parse("2017/07/12") } );
            list.Add(new Reserva { DNI = listInvestigadores[1].DNI, NumSerie = listEquipos[2].numSerie, Comienzo = DateTime.Parse("2017/07/23"), Fin = DateTime.Parse("2017/08/7") });

            return list;
        }
    }
}
