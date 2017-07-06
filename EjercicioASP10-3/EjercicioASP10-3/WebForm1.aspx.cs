using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP10_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sqlOrders_Deleting(object sender, SqlDataSourceCommandEventArgs e)
        {
            if (!chkDelete.Checked)
            {
                e.Cancel = true;
                lblDeleting.Visible = true;
                lblDeleting.Text = "Operación cancelada";
            }
        }

        protected void sqlOrders_Deleted(object sender, SqlDataSourceStatusEventArgs e)
        {
            if (e.Exception != null)
            {
                lblDeleting.Visible = true;
                lblDeleting.Text = e.Exception.Message;
                e.ExceptionHandled = true;
            }
            else
            {
                lblDeleting.Visible = true;
                lblDeleting.Text = e.AffectedRows.ToString() + " linea(s) afectada(s)";
            }
        }
    }
}