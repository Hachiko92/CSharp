using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP5_0_1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string dato1 = Request.Form["CompanyName"].ToString();
            lblCompany.Text += dato1;

            string dato2 = Request.Form["ContactName"].ToString();
            lblContact.Text += dato2;

            string dato3 = Request.Form["Employees"].ToString();
            lblEmployees.Text += dato3;
        }
    }
}