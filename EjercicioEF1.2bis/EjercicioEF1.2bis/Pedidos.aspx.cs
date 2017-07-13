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

        protected void ddlClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new Model1Container())
            {
                var clientes = from c in context.ClientesSet
                               select new
                               {
                                   Nombre = c.CompanyName,
                                   ID = c.Id
                               };

                ddlClientes.DataSource = clientes;
                ddlClientes.DataBind();
            }
        }

        protected void btnPedir_Click(object sender, EventArgs e)
        {
            spanCliente.Visible = false;
            spanProducto.Visible = false;

            int IDcliente = Convert.ToInt32(ddlClientes.SelectedValue);
            int IDproducto = Convert.ToInt32(ddlProducto.SelectedValue);
            string producto = ddlProducto.SelectedIndex.ToString();
            int cantidad = Convert.ToInt32(txtCantidad.Text);

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

                    Pedidos pedido = new Pedidos
                    {
                        Cantidad = cantidad,
                        ClienteID = IDcliente,
                        ProductoID = IDproducto
                    };

                    List<String> lista = new List<String>
                    {
                        (pedido.Id).ToString(),
                        producto,
                        cantidad.ToString(),
                        precio.ToString(),
                        total
                    };

                    grdPedido.DataSource = lista;
                    grdPedido.DataBind();

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