using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjerciciosASP13Sql
{
    public partial class Ejercicio13_6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var media = (from em in db.Employees
                            join o in db.Orders
                            on em.EmployeeID equals o.EmployeeID
                            join od in db.Order_Details
                            on o.OrderID equals od.OrderID
                            where em.FirstName == "Michael" && em.LastName == "Suyama"
                            select od.Quantity * od.UnitPrice)
                            .Average();

                span.InnerHtml = media.ToString();
            }
        }
    }
}