using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto37_MasterPage1
{
    public partial class Pagina2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* como hay en el medio la pagina maestra, cambia un poco */
            //string valor = Request.Form["txtNombre"];
            /* ctl -> control, 00 -> primera posición */
            string valor = Request.Form["ctl00$Contenido$txtNombre"];
            TextBox1.Text = valor;

            txtFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}