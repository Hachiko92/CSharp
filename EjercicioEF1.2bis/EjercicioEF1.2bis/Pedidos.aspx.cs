using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioEF1._2bis
{
    public partial class Pedidos1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using(var context = new Model1Container())
                {
                    var clientes = from c in context.ClientesSet
                                   select new
                                   {
                                       Company = c.CompanyName,
                                       ID = c.Id
                                   };

                    ddlClientes.DataSource = clientes.ToList() ;
                    ddlClientes.DataTextField = "Company";
                    ddlClientes.DataValueField = "ID";
                    ddlClientes.DataBind();

                    var productos = from p in context.ProductosSet
                                   select new
                                   {
                                       Producto = p.ProductName,
                                       ID = p.Id
                                   };

                    ddlProducto.DataSource = productos.ToList();
                    ddlProducto.DataTextField = "Producto";
                    ddlProducto.DataValueField = "ID";
                    ddlProducto.DataBind();
                }
            }
        }

        //protected void ddlClientes_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    using (var context = new Model1Container())
        //    {
        //        var clientes = from c in context.ClientesSet
        //                       select new
        //                       {
        //                           Nombre = c.CompanyName,
        //                           ID = c.Id
        //                       };

        //        ddlClientes.DataSource = clientes;
        //        ddlClientes.DataBind();
        //    }
        //}

        protected void btnPedir_Click(object sender, EventArgs e)
        {
            spanCliente.Visible = false;
            spanProducto.Visible = false;

            int IDcliente = Convert.ToInt32(ddlClientes.SelectedValue);
            int IDproducto = Convert.ToInt32(ddlProducto.SelectedValue);
            int cantidad = Convert.ToInt32(txtCantidad.Text);

            using (var context = new Model1Container())
            {
                if (IDcliente == 0)
                {
                    spanCliente.Visible = true;
                }
                else
                {
                    if (IDproducto == 0)
                    {
                        spanProducto.Visible = true;
                    }
                    else
                    {
                        decimal precio = GetPrecio(IDproducto);
                        string total = (precio * cantidad).ToString();

                        var clientePedido = (from c in context.ClientesSet
                                            where c.Id == IDcliente
                                            select c).FirstOrDefault();

                        var productoPedido = (from p in context.ProductosSet
                                       where p.Id == IDproducto
                                       select p).FirstOrDefault();

                        Pedidos pedido = new Pedidos
                        {
                            Cantidad = cantidad,
                            ClienteID = IDcliente,
                            ProductoID = IDproducto,
                            Clientes = clientePedido,
                            Productos = productoPedido
                        };
                        
                        context.PedidosSet.Add(pedido);
                        context.SaveChanges();

                        var pedido3 = ((from p in context.PedidosSet
                                        orderby p.Id descending
                                        select new
                                        {
                                            ID = p.Id,
                                            Producto = p.Productos.ProductName,
                                            Cantidad = cantidad,
                                            PrecioUnidad = precio,
                                            Total = total
                                        }).Take(1)).ToList();

                        grdPedido.DataSource = pedido3;
                        grdPedido.DataBind();

                    }
                }
            }
        }

        private decimal GetPrecio(int id)
        {
            using(var context = new Model1Container())
            {
                decimal precio = Convert.ToDecimal((from p in context.ProductosSet
                                                    where p.Id == id
                                                    select p.UnitPrice).FirstOrDefault());
                return precio;
            }
        }
    }
}