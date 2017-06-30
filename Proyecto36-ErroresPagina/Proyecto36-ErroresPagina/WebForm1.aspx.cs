using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto36_ErroresPagina
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LanzarError();
        }
        private void LanzarError()
        {
            throw new ApplicationException("Has lanzado una excepcion. Cuidadin!");
        }
        ///* tiene que llamarse Page_Error */
        //private void Page_Error(object sender, EventArgs e)
        //{
        //    Exception ex = Server.GetLastError();
        //    Response.Write("<h1>Un error ha ocurrido</h1>");
        //    Response.Write("<h2>" + ex.Message + "</h2>");
        //    /* StackTrace enseña donde ha pasado el error */
        //    Response.Write("<pre>" + ex.StackTrace + "</pre>");
        //    Server.ClearError();
        //}
    }
}