using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP9_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cbxTemporada_SelectedIndexChanged(object sender, EventArgs e)
        {
            result.InnerHtml = "";
            foreach (ListItem checkbox in cbxTemporada.Items)
            {
                if (checkbox.Selected)
                {
                    if(result.InnerHtml == "")
                    {
                        result.InnerHtml = "Temporada(s) elejida(s):<br>";
                    }

                    result.InnerHtml += "<br>Temporada " + checkbox.Value;
                }
            }
        }
    }
}