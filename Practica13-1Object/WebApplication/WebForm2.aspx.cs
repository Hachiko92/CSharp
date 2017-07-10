using Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public List<Equipo> equipos;

        protected void Page_Load(object sender, EventArgs e)
        {
            equipos = Session["Lista"] as List<Equipo>;
            string dni = (string)Session["dni"];
            string nombre = (string)Session["profesor"];
            string fInicio = (string)Session["fInicio"];
            string fFin = (string)Session["fFin"];

            lblProfesor.Text += nombre;
            lblDNI.Text = dni;
            lblFinicio.Text = fInicio;
            lblFfin.Text = fFin;
        }
    }
}