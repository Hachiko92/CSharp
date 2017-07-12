using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto47_Seguridad.ZonaDeAdministracion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvVerUsuarios.DataSource = Membership.GetAllUsers();
            gvVerUsuarios.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            gvUsuariosPorNombre.DataSource = Membership.FindUsersByName(txtBuscar.Text);
            gvUsuariosPorNombre.DataBind();
        }
    }
}