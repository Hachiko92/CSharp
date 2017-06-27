using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP2_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] tools = new string[] { "Tablesaw", "Bandsaw", "Planer", "Jointer", "Brill", "Bander" };

            IEnumerable<string> lista =
                from palabra in tools
                select palabra.ToUpper();

            StringBuilder sb = new StringBuilder();

            foreach (string palabra in lista)
            {
                sb.Append("<strong>" + palabra + "</strong><br>");
            }

            string resultado = sb.ToString();
            result.InnerHtml= resultado;
        }
    }
}