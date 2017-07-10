using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto46_LinqToSql
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = (from od in db.Order_Details
                            where od.OrderID.Equals(10250)
                            select od.Quantity * od.UnitPrice).Sum();
            }
        }
    }
}