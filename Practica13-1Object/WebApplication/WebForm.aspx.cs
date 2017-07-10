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

                txtDNI.Text = (fila.Cells[1] as TableCell).Text.ToString();
                txtProfesor.Text = (fila.Cells[2] as TableCell).Text.ToString();

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

        protected void btnReservar_Click(object sender, EventArgs e)
        {
            List<Equipo> EquipoReservas = new List<Equipo>();

            foreach (GridViewRow row in GridViewReserva.Rows)
            {
                CheckBox check = row.FindControl("chk") as CheckBox;
                if (check.Checked)
                {
                    Equipo equipo = new Equipo();
                    equipo.numSerie = GridViewReserva.Rows[row.RowIndex].Cells[0].Text;
                    equipo.Nombre = GridViewReserva.Rows[row.RowIndex].Cells[1].Text;
                    string nombre = (GridViewReserva.Rows[row.RowIndex].Cells[2].Text).ToString();
                    equipo.Facultad = Facultad.ObtenerIdFacultad(nombre);
                }

                Session["lista"] = EquipoReservas;
                Session["dni"] = txtDNI.Text;
                Session["profesor"] = txtProfesor.Text;
                Session["fInicio"] = txtInicio.Text;
                Session["fFin"] = txtFin.Text;

                Server.Transfer("WebForm2.aspx");
            }

        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            calendar.SelectedDates.Clear();
            calendar.Visible = true;
            Session["viene"] = "a";
            btnInicio.Visible = false;
        }

        protected void btnFin_Click(object sender, EventArgs e)
        {
            calendar.SelectedDates.Clear();
            calendar.Visible = true;
            Session["viene"] = "b";
            btnInicio.Visible = false;
        }

        protected void calendar_SelectionChanged(object sender, EventArgs e)
        {
            if(Session["viene"] == "a")
            {
                txtInicio.Text = calendar.SelectedDate.ToShortDateString();
            }

            if (Session["viene"] == "b")
            {
                txtFin.Text = calendar.SelectedDate.ToShortDateString();
            }

            calendar.Visible = false;
            btnInicio.Visible = true;
            btnFin.Visible = true;
        }
    }
}