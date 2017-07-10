using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto46_LinqToSql
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from c in db.Customers
                           where c.Country == "Spain"
                           select c;

                foreach (Customer d in data)
                {
                    Response.Write(d.ContactName + "<br>");
                }
            }
        }
    }
}