using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjerciciosASP13Sql
{
    public partial class Ejercicio13_4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var SaoPaulo = db.Customers
                              .Where(c => c.City == "Sao Paulo")
                              .Select(c => new
                              {
                                  Nombre = c.CompanyName
                              });

                dtlClientes.DataSource = SaoPaulo;
                dtlClientes.DataBind();

                var Londres = db.Employees
                             .Where(em => em.City == "London")
                             .OrderBy(em => em.BirthDate)
                             .Select(em => new
                             {
                                 Nombre = em.FirstName + " " + em.LastName,
                                 Fecha = em.BirthDate
                             });

                //foreach (var em in Londres)
                //{
                //    em.Fecha = Convert.ToDateTime(em.Fecha).ToShortDateString;
                //}

                dtlEmpleados.DataSource = Londres;
                dtlEmpleados.DataBind();

                var productos = db.Products
                               .Where(p => p.UnitPrice > 50)
                               .Select(p => new
                               {
                                   Producto = p.ProductName,
                                   Unidades = p.UnitsInStock
                               });

                dtlProductos.DataSource = productos;
                dtlProductos.DataBind();
            }
        }
    }
}