using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP10_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grdEmployees_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Select"))
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow fila = grdEmployees.Rows[index];

                txtApellido.Text = fila.Cells[2].Text.ToString();
                txtNombre.Text = fila.Cells[3].Text.ToString();
                txtCargo.Text = fila.Cells[4].Text.ToString();
            }
        }
    }
}