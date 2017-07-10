using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjerciciosASP13Sql
{
    public partial class Ejercicio13_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var productos = from p in db.Products
                                where p.UnitPrice > 50
                                select new
                                {
                                    Producto = p.ProductName,
                                    Unidades = p.UnitsInStock
                                };

                DataList1.DataSource = productos;
                DataList1.DataBind();
            }
        }
    }
}