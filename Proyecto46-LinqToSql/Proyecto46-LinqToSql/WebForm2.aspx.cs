using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto46_LinqToSql
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var customers = (from c in db.Customers
                                 where c.Country == "Spain"
                                 orderby c.CompanyName
                                 select new
                                 {
                                     c.CustomerID,
                                     c.CompanyName,
                                     c.Country,
                                     Pedidos = c.Orders.Count
                                 });

                foreach(var c in customers)
                {
                    span.InnerHtml = c.CustomerID + " " + c.CompanyName + " " + c.Country + " " + c.Pedidos + "<br>";
                }
            }
            
        }
    }
}