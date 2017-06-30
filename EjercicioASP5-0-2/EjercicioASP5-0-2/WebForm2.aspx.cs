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
            //lblName.Text += Request.QueryString["valor1"];
            //lblCategory.Text += Request.QueryString["valor2"];
            //lblSupplier.Text += Request.QueryString["valor3"];
            //lblPrice.Text += Request.QueryString["valor4"];

            ///* Server transfer */
            //lblName.Text += Request.Form["txtName"].ToString();
            //int category = int.Parse(Request.Form["ddlCategory"]);
            //int supplier = int.Parse(Request.Form["ddlSupplier"]);
            //lblPrice.Text += Request.Form["txtPrice"].ToString();

            /* Server transfer, HiddenForm */
            //lblName.Text += Request.Form["txtName"].ToString();
            //lblCategory.Text += Request.Form["HiddenForm1"];
            //lblSupplier.Text += "";
            //lblPrice.Text += Request.Form["txtPrice"].ToString();

            /* Response.Redirect */
            lblName.Text += Request.QueryString["valor1"];
            int category = Convert.ToInt32(Request.QueryString["valor2"]);
            int supplier = Convert.ToInt32(Request.QueryString["valor3"]);
            lblPrice.Text += Request.QueryString["valor4"];
            
            switch (category)
            {
                case 1:
                    lblCategory.Text += "casa";
                    break;
                case 2:
                    lblCategory.Text += "coche";
                    break;
                case 3:
                    lblCategory.Text += "alimentación";
                    break;
                case 4:
                    lblCategory.Text += "bellezza";
                    break;
                default:
                    lblCategory.Text += "errore";
                    break;
            }

            switch (supplier)
            {
                case 1:
                    lblSupplier.Text += "pippo";
                    break;
                case 2:
                    lblSupplier.Text += "fiat";
                    break;
                case 3:
                    lblSupplier.Text += "conad";
                    break;
                case 4:
                    lblSupplier.Text += "flomar";
                    break;
                default:
                    lblSupplier.Text += "errore";
                    break;
            }
        }
    }
}