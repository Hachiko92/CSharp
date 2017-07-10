using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto46_LinqToSql
{
    public partial class WebForm3_SelectMany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data1 = (from c in db.Customers
                             where c.Country == "Spain"
                             select c)
                             .SelectMany(c => c.Orders)
                             .ToList();

                foreach (var item in data1)
                {
                    //Response.Write(item.)
                }
            }
        }
    }
}