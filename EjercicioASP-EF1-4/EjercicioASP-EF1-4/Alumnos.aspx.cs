using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP_EF1_4
{
    public partial class Alumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarAlumnos();
            }
        }

        private void CargarAlumnos()
        {
            using (var db = new AcademiaClasesEntities())
            {
                var query = db.Alumno
                           .Select(a => a)
                           .OrderBy(a => a.Nombre)
                           .ToList();

                ddlAlumnos.DataSource = query;
                ddlAlumnos.DataTextField = "Nombre";
                ddlAlumnos.DataValueField = "Id";
                ddlAlumnos.DataBind();
            }
        }
    }
}