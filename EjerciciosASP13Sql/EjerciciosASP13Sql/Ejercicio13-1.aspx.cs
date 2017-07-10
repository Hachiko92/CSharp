using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjerciciosASP13Sql
{
    public partial class Ejercicio13_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from c in db.Customers
                           where c.City == "Sao Paulo"
                           select c;

                foreach (Customer c in data)
                {
                    result.InnerHtml += c.CompanyName + "<br>";
                }
            }
        }
    }
}