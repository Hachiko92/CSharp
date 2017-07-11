using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjerciciosASP13Sql
{
    public partial class Ejercicio13_9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            /* Listado de OrderID y OrderDate de los clientes de la region de WA */
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var pedidos = from c in db.Customers
                              join o in db.Orders
                              on c.CustomerID equals o.CustomerID
                              where c.Region == "WA"
                              orderby o.OrderDate
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

        protected void btn3_Click(object sender, EventArgs e)
        {
            /* Listado pedidos desde el 01/01/1998 */
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                DateTime fecha = new DateTime(1998, 1, 1);
                var pedidos = from o in db.Orders
                              where o.OrderDate.Value >= fecha
                              orderby o.OrderDate
                              select new
                              {
                                  Cliente = o.CustomerID,
                                  Pedido = o.OrderID,
                                  Fecha = Convert.ToDateTime(o.OrderDate).ToShortDateString()
                              };

                GridView1.DataSource = pedidos;
                GridView1.DataBind();
            }
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            /* Listado pedidos desde el 01/01/1997 efectuado por los clientes de WA */
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                DateTime fecha = new DateTime(1997, 1, 1);
                var pedidos = from o in db.Orders
                              join c in db.Customers on o.CustomerID equals c.CustomerID
                              where o.OrderDate.Value > fecha && c.Region == "WA"
                              orderby o.OrderDate
                              select new
                              {
                                  Cliente = o.CustomerID,
                                  Pedido = o.OrderID,
                                  Fecha = Convert.ToDateTime(o.OrderDate).ToShortDateString()
                              };

                GridView1.DataSource = pedidos;
                GridView1.DataBind();
            }
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            /* Listado de productos con sus categoria (DESC) */
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var productos = from p in db.Products
                                join c in db.Categories on p.CategoryID equals c.CategoryID
                                orderby p.ProductID descending
                                select new
                                {
                                    IDProducto = p.ProductID,
                                    Producto = p.ProductName,
                                    Categoria = c.CategoryName
                                };

                GridView1.DataSource = productos;
                GridView1.DataBind();
            }
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            /* Listado de las categorias con sus producto mas caro */
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                //var categorias = from c in db.Categories
                //                 join p in ((from p in db.Products
                //                             orderby p.UnitPrice descending
                //                             select p).Take(1))
                //                 on c.CategoryID equals p.CategoryID
                //                 select new
                //                 {
                //                     Categoria = c.CategoryName,
                //                     Producto = p.ProductName
                //                 };

                //var categorias = from c in db.Categories
                //                 join p in db.Products
                //                 on c.CategoryID equals p.CategoryID
                //                 select new
                //                 {
                //                     Categoria = c.CategoryName,
                //                     Producto = p.ProductName
                //                 };

                //var categorias = from c in db.Categories
                //                 join p in db.Products
                //                 on c.CategoryID equals p.CategoryID

                //                 select new
                //                 {
                //                     Categoria = c.CategoryName,
                //                     Producto = p.ProductName
                //                 };

                //var productos = from p in db.Products
                //                group p by p.CategoryID into pp
                //                orderby pp.FirstOrDefault().UnitPrice descending
                //                select new
                //                {
                //                    Categoria = pp.FirstOrDefault().CategoryID,
                //                    Producto = pp.FirstOrDefault().ProductName,
                //                    Precio = pp.FirstOrDefault().UnitPrice
                //                };

                //var productos = from c in db.Categories
                //                join p in (from p in db.Products
                //                           group p by p.CategoryID into pp
                //                           select new
                //                           {
                //                               Precio = pp.Max(p => p.UnitPrice),
                //                               Categoria = pp.FirstOrDefault().CategoryID
                //                           })
                //                on c.CategoryID equals p.Categoria
                //                join pp in db.Products on c.CategoryID equals pp.CategoryID
                //                select new
                //                {
                //                    Categoria = c.CategoryName.Distinct(),
                //                    Producto = pp.ProductName,
                //                    Precio = p.Precio


                //var productos = (from c in db.Categories
                //                join p in (from p in db.Products
                //                           group p by p.CategoryID into pp
                //                           select new
                //                           {
                //                               Precio = pp.Max(p => p.UnitPrice),
                //                               Categoria = pp.FirstOrDefault().CategoryID
                //                           })
                //                on c.CategoryID equals p.Categoria
                //                select new
                //                {
                //                    Categoria = c.CategoryName,
                //                    Precio = p.Precio
                //                }).ToList();

                //var pName = from p in db.Products
                //            join c in db.Categories on p.CategoryID equals c.CategoryID
                //            where p.CategoryID == productos.
                //            && p.UnitPrice == Convert.ToInt32(productos.Select(pp => pp.Precio))
                //            select new
                //            {
                //                Categoria = c.CategoryName,
                //                Producto = p.ProductName,
                //                Precio = p.UnitPrice
                //            };
                
                //List<DataClasses1DataContext> ciccia = new List<DataClasses1DataContext>();
                //foreach (var item in productos)
                //{
                //    foreach (var item2 in pName)
                //    {
                //        if (item2.)
                //    }
                //}

                //GridView1.DataSource = pName;
                //GridView1.DataBind();

                //var categorias = from p in db.Products
                //                 group p by p.Category into g
                //                 select new
                //                 {
                //                     Categoria = g.Key,
                //                     Precio = g.Max(p => p.UnitPrice)
                //                 };

                //foreach (var productos in categorias)
                //{
                //    var nombreProducto = db.Products
                //                        .FirstOrDefault(p => p.CategoryID == productos.Categoria.CategoryID && p.UnitPrice == productos.Precio);
                //}

                //var final = from p in nombreProducto
                //            join
            }
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            /* media de los productos por cada categoria */
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var productos = from c in db.Categories
                                join p in (from p in db.Products
                                           group p by p.CategoryID into pp
                                           select new
                                           {
                                               Productos = pp.Average(p => p.UnitPrice),
                                               Categoria = pp.Key
                                           })
                                on c.CategoryID equals p.Categoria
                                select new
                                {
                                    Categoria = c.CategoryName,
                                    Media = p.Productos
                                };

                //var categories = from p in db.Products
                //                 group p by p.CategoryID into g
                //                 select new
                //                 {
                //                     Categoria = g.Key,
                //                     Media = g.Average(p => p.UnitPrice)
                //                 };

                GridView1.DataSource = productos;
                GridView1.DataBind();
            }
        }
    }
}