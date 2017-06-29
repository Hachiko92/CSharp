using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP1_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                float result = Convert.ToSingle(txtNum1.Text) + Convert.ToSingle(txtNum2.Text);
                Response.Write(result);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                float result = Convert.ToSingle(txtNum1.Text) - Convert.ToSingle(txtNum2.Text);
                Response.Write(result);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}