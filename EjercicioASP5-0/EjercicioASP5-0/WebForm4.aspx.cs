using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP5_0
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(Request.Form["TextBox1"]);
            TextBox1.Text = valor.ToString();
        }
    }
}