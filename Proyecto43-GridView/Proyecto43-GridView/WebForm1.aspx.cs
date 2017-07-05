using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto43_GridView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Print"))
            {
                /* index es el indice de la fila en la cual se encuentra cuando se dispara el evento */
                int index = Convert.ToInt32(e.CommandArgument);
                /* Fila es la fila de donde se ha disparato el evento */
                GridViewRow fila = GridView1.Rows[index];

                TableCell company = fila.Cells[1];
                string nombreCompania = company.Text.ToString();

                Response.Write("<br>" + nombreCompania + "<br><br>");

            }
        }
    }
}