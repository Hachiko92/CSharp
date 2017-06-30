using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP5_0_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsCallback)
            {
                HiddenField1.Value = ddlCategory.SelectedItem.Text;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string dato1 = txtName.Text;
            int dato2 = int.Parse(ddlCategory.SelectedValue);
            int dato3 = int.Parse(ddlSupplier.SelectedValue);
            string dato4 = txtPrice.Text;
            Response.Redirect("WebForm2.aspx?valor1=" + dato1 + "&valor2=" + dato2 + "&valor3=" + dato3 + "&valor4=" + dato4);
            //Server.Transfer("WebForm2.aspx");
        }
    }
}