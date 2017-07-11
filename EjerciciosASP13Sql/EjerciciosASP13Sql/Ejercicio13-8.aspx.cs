using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjerciciosASP13Sql
{
    public partial class Ejercicio13_8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var categorias = from c in db.Categories
                                     select new
                                     {
                                         ID = c.CategoryID,
                                         Categoria = c.CategoryName,
                                         Descripcion = c.Description,
                                         Foto = c.Picture
                                     };

                    grdCategorias.DataSource = categorias;
                    grdCategorias.DataBind();
                }
            }
        }

        protected void grdCategorias_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "calcular")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow fila = grdCategorias.Rows[index];
                int categoria = Convert.ToInt32(fila.Cells[1].Text);

                getTotal(categoria);
            }
            
        }

        private void getTotal(int categoria)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var total = (from p in db.Products
                             where p.CategoryID == categoria
                             select Convert.ToInt32(p.UnitsInStock)).Sum();

                txtTotal.Text = total.ToString();
            }
        }
    }
}