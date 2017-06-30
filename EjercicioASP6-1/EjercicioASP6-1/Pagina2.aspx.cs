using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP6_1
{
    public partial class Pagina2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombreConcatenado = Request.Form["ctl00$cuerpo$txtNombre"] + " " + Request.Form["ctl00$cuerpo$txtApellido"];
            txtNombreCompleto.Text = nombreConcatenado;
        }
    }
}