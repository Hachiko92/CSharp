using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP5_1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox txtAltura1 = (TextBox)PreviousPage.FindControl("txtAltura1");
            TextBox txtPeso1 = (TextBox)PreviousPage.FindControl("txtPeso1");
            TextBox txtAltura2 = (TextBox)PreviousPage.FindControl("txtAltura2");
            TextBox txtPeso2 = (TextBox)PreviousPage.FindControl("txtPeso2");
            TextBox txtAltura3 = (TextBox)PreviousPage.FindControl("txtAltura3");
            TextBox txtPeso3 = (TextBox)PreviousPage.FindControl("txtPeso3");

            double indice1 = CalcularIndice(Convert.ToInt32(txtAltura1.Text), Convert.ToInt32(txtPeso1.Text));
            double indice2 = CalcularIndice(Convert.ToInt32(txtAltura2.Text), Convert.ToInt32(txtPeso2.Text));
            double indice3 = CalcularIndice(Convert.ToInt32(txtAltura3.Text), Convert.ToInt32(txtPeso3.Text));

            txtIndice1.Text = indice1.ToString();
            txtIndice2.Text = indice2.ToString();
            txtIndice3.Text = indice3.ToString();
        }

        private double CalcularIndice(int altura, int peso)
        {
            double indice = peso / Math.Pow(altura, 2);
            return indice;
        }
    }
}