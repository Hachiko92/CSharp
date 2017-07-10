using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjerciciosASP13Sql
{
    public partial class Ejercicio13_5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from o in db.Orders
                           join em in db.Employees
                           on o.EmployeeID equals em.EmployeeID
                           orderby o.OrderDate, em.LastName
                           select new
                           {
                               Empleado = em.FirstName + " " + em.LastName,
                               Pedido = o.OrderDate
                           };

                //var consulta = from em in db.Employees
                //               group em by em.Employees into emp
                //               join o in db.Orders
                //               on emp.FirstOrDefault().EmployeeID equals o.EmployeeID
                //               orderby o.OrderDate
                //               select new
                //               {
                //                   Empleado = emp.FirstOrDefault().FirstName + " " + emp.FirstOrDefault().LastName,
                //                   Pedido = o.OrderDate
                //               };

                dtlPedidos.DataSource = data;
                dtlPedidos.DataBind();

                //foreach (var item in consulta)
                //{
                //    Response.Write("(" + item.Pedido + ") " + item.Empleado);
                //}
            }
        }
    }
}