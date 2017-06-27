using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyect33c
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string aString = "ABCDE99F-374-12-89A";

            IEnumerable<char> stringQuery =
                from c in aString
                where Char.IsDigit(c)
                select c;

            foreach (char c in stringQuery)
            {
                Response.Write(c + "");
                Response.Write("<br>");
            }
        }
    }
}