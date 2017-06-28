using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP4_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string ConcatenarNombre()
        {
            string nombreCompleto = txtNombre.Text + " " + txtApellido.Text;
            return nombreCompleto;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string opcion = "";
            if (chkNet.Checked)
            {
                opcion += chkNet.Text + " ";
            }
            if (chkPhp.Checked)
            {
                opcion += chkPhp.Text + " ";
            }
            if (chkJava.Checked)
            {
                opcion += chkJava.Text + " ";
            }

            string resultado = ConcatenarNombre() + " " + opcion;
            Response.Write(resultado);
        }
    }
}