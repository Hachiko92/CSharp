using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //list<Books> libros = Books.GetBooks()

            var libros = from b in Books.GetBooks()
                         where b.Price <= 1500 && b.Title == "Programming in C#"
                         select b;

            //GridView1.DataSource = libros;
            //GridView1.DataBind();
            
            /* con IEnumerable no es necesario poner .ToList() porque ya es una lista */
            IEnumerable<Books> books = (Books.GetBooks()
                                       .Where(b => b.Price <= 1500 || b.Title == "Programming in C#")
                                       .Select(b => b)).ToList();

            int i = 0;
            var titles = from book in Books.GetBooks()
                         select new
                         {
                             Titulo = book.Title,
                             Precio = book.Price,
                             Otra = ++i
                         };

            GridView1.DataSource = titles;
            GridView1.DataBind();

            IEnumerable<String> titulos = (Books.GetBooks()
                                          .Select(book => book.Title)).ToList();

            List<decimal> precios = (Books.GetBooks()
                                    .Select(book => book.Price)).ToList();
        }
    }
}