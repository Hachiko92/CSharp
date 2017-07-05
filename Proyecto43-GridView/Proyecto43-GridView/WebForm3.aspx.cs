using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto43_GridView
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Deleting(object sender, SqlDataSourceCommandEventArgs e)
        {
            if (! role.SelectedValue.Equals("2"))
            {
                /* si no cumple la condicion que necesita, el evento no sigue */
                e.Cancel = true;
                label1.Text = "Comando cancelado porque no cumple el Role de Administrador";
                label1.Visible = true;
            }
        }

        protected void SqlDataSource1_Deleted(object sender, SqlDataSourceStatusEventArgs e)
        {
            label1.Visible = true;
            /* e.AffectedRows no necesetaria ser convertido (porque está concatenado en una stringa) */
            label1.Text = e.AffectedRows.ToString() + " row(s) were affected";
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Seleccionar_Index")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow fila = GridView1.Rows[index];
                TableCell producto = fila.Cells[1];
                TableCell precio = fila.Cells[2];
                string pro = producto.Text;
                string val = precio.Text;
            }
        }
    }
}