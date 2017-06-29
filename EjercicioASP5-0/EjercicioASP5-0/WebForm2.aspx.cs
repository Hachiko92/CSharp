using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP5_0
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* va entrar solo cuando es la primera vez que pasa de aqui
             * el boton ha creado la necesitad de utilizarlo */
            if (!IsPostBack)
            {
                string datos = "";
                datos += Request.Form["txtNombre"].ToString();
                datos += " " + Request.Form["txtApellido"].ToString();

                txtConcatenado.Text = datos;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Redirect("WebForm3.aspx");
            /* asi le pasa una variable que se llama valor y vale 23*/
            //Response.Redirect("WebForm3.aspx?valor=" + 23);
            //Response.Redirect("WebForm3.aspx?valor=Pepe");

            //string cadena = txtConcatenado.Text;
            //Response.Redirect("WebForm3.aspx?valor=" + txtConcatenado);

            Response.Redirect("WebForm3.aspx?valor1=" + 23 + "&valor2=" + 54);

        }
    }
}