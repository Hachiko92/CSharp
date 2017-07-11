using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioLinqSql13_9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            /* Listado de OrderID y OrderDate de los clientes de la region de WA */
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var pedidos = from c in db.Customers
                              join o in db.Orders
                              on c.CustomerID equals o.CustomerID
                              where c.Region == "WA"
                              select new
                              {
                                  Pedido = o.OrderID,
                                  Fecha = Convert.ToDateTime(o.OrderDate).ToShortDateString()
                              };

                GridView1.DataSource = pedidos;
                GridView1.DataBind();
            }
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            /* Listado Clientes y su numero de pedidos realizados */
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var clientes = from o in db.Orders
                               group o by o.CustomerID
                               into cc
                               select new
                               {
                                   Cliente = cc.FirstOrDefault().CustomerID,
                                   Pedidos = cc.Count()
                               };


                GridView1.DataSource = clientes;
                GridView1.DataBind();
            }
        }
    }
}