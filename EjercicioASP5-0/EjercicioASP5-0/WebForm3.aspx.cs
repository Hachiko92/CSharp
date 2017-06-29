using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP5_0
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //int valor = Convert.ToInt32(Request.QueryString["valor"]);
            //string valor = Request.QueryString["valor"];

            int valor1 = Convert.ToInt32(Request.QueryString["valor1"]);
            int valor2 = Convert.ToInt32(Request.QueryString["valor2"]);
            int suma = valor1 + valor2;

            TextBox1.Text = suma.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm4.aspx");
        }
    }
}