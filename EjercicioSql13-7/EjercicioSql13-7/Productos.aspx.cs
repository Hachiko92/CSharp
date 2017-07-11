using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioSql13_7
{
    public partial class Ejercicio13_7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                if (!IsPostBack)
                {
                    var categorias = from c in db.Categories
                                     select new
                                     {
                                         Categoria = c.CategoryName,
                                         ID = c.CategoryID
                                     };

                    ddlCategorias.DataSource = categorias;
                    ddlCategorias.DataTextField = "Categoria";
                    ddlCategorias.DataValueField = "ID";
                    ddlCategorias.DataBind();
                }
            }
        }

        protected void ddlCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCategoria = Convert.ToInt32(ddlCategorias.SelectedIndex);

            if (idCategoria != 0)
            {
                getProducs(idCategoria);
            }
            else
            {
                Response.Write("Seleccione una categoria");
            }
        }

        protected void getProducs(int categoria)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var productos = from p in db.Products
                                where p.CategoryID.Equals(categoria)
                                select new
                                {
                                    ID = p.ProductID,
                                    Producto = p.ProductName,
                                    Precio = p.UnitPrice
                                };

                grdProductos.DataSource = productos;
                grdProductos.DataBind();
            }
        }
    }
}