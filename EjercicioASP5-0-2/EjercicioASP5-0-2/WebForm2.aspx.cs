using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP5_0_2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text += Request.QueryString["valor1"];
            lblCategory.Text += Request.QueryString["valor2"];
            lblSupplier.Text += Request.QueryString["valor3"];
            lblPrice.Text += Request.QueryString["valor4"];
        }
    }
}