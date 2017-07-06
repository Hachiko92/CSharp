using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Books> books = Books.GetBooks();

            /* creando un nuevo objeto (select new) la cabecera del GridView tendrá 
             * el nombre de las columnas (Title y Price) */
            var booktitles = from b in books
                             where b.Title.Length > 10
                             orderby b.Price descending
                             select new
                             {
                                 b.Title,
                                 b.Price
                             };

            GridView1.DataSource = booktitles.ToList();
            GridView1.DataBind();
        }
    }
}