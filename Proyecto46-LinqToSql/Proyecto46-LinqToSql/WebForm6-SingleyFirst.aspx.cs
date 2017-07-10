using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto46_LinqToSql
{
    public partial class WebForm6_SingleyFirst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data1 = (from c in db.Customers
                            join o in (from t in db.Orders
                                       where t.OrderDate.Value.Year == 1998
                                       && t.OrderDate.Value.Month.Equals(5)
                                       select t)
                            on c.CustomerID equals o.CustomerID
                            select new
                            {
                                Country = c.Country,
                                OrderDate = o.OrderDate
                            }).FirstOrDefault(x => x.Country == "USA");

                /*  */
            }
        }
    }
}