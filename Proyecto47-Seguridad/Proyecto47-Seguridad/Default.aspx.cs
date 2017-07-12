using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto47_Seguridad
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Roles.IsUserInRole("Administrador"))
            {
                LinkButton link = (LinkButton)LoginView1.FindControl("lnkGestion");
                link.Visible = true;
            }
        }

        protected void LinkCambioPw_Click(object sender, EventArgs e)
        {

        }
    }
}