using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP2_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] Birds = { "Indigo Bunting", "Rose Breasted Grosbeak", "Robin", "House Finch", "Gold Finch", "Ruby Throated Hummingbird", "Rufous Hummingbird", "Downy Woodpecker" };

            /* b es una variable de paso y normalmente se utiliza la inicial de lo que se utiliza*/
            var lista = from b in Birds
                        where b.StartsWith("R")
                        select b;

            StringBuilder sb = new StringBuilder();
            foreach (string s in lista)
            {
                sb.Append(s + "<br>");
            }

            Response.Write("<b>Con R:</b><br>");
            Response.Write(sb);

            var lista2 = (from b in Birds
                         where b == "House Finch"
                         select b).FirstOrDefault();

            if (lista2 != "")
            {
                foreach (char b in lista2)
                {
                    sb = new StringBuilder();
                    foreach (char s in lista2)
                    {
                        sb.Append(s);
                    }

                    Response.Write("<b>\"House Finch\" encontrados:</b><br>");
                    Response.Write(sb);
                }
            }
            else
            {
                Response.Write("House Finch no encontrado");
            }

            var lista3 = from b in Birds
                        orderby b ascending
                        select b;

            sb = new StringBuilder();
            foreach (string s in lista3)
            {
                sb.Append(s + "<br>");
            }

            Response.Write("<b>Ordenado:</b><br>");
            Response.Write(sb);
       }
    }
}