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
    }
}