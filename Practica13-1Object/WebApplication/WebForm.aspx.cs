using Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewProfesores.DataSource = 
                                    (Investigador.getInvestigador()
                                    .Join(Facultad.GetFacultad(), investigador => investigador.Facultad, facultad => facultad.Codigo, (investigador, facultad) => new
                                    {
                                        DNI = investigador.DNI,
                                        Profesor = investigador.NombreApellido,
                                        Facultad = facultad.Nombre
                                    })).ToList();
                GridViewProfesores.DataBind();
            }
        }

        protected void GridViewProfesores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Reservar"))
            {
                
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow fila = GridViewProfesores.Rows[index];

                txtDNI.Text = (fila.Cells[1] as TableCell).ToString();
                txtProfesor.Text = (fila.Cells[2] as TableCell).ToString();

                GridViewReserva.DataSource = (Equipo.GetEquipo()
                                              .Join(Facultad.GetFacultad(), equipo => equipo.Facultad, facultad => facultad.Codigo, (equipo, facultad) => new
                                              {
                                                  Numero = equipo.numSerie,
                                                  Equipo = equipo.Nombre,
                                                  Facultad = facultad.Nombre
                                              })).ToList();
                GridViewReserva.DataBind();
            }
        }
    }
}