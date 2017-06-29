using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto34b
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextValidate(object source, ServerValidateEventArgs args)
        {
            /* Declaro la condiciòn que debe convalidar, en este caso que la 
             * longitud sea >= 8 */
            args.IsValid = (args.Value.Length >= 8);
        }
    }
}