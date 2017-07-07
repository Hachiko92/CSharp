using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var librosOrdenados = from book in Books.GetBooks()
                                  orderby book.Author, book.Price descending, book.Title
                                  select new
                                  {
                                      Autor = book.Author,
                                      Precio = book.Price,
                                      Titulo = book.Title
                                  };

            var librosOrdenadosLambda = (Books.GetBooks()
                                       .OrderBy(n => n.Author)
                                       .ThenByDescending(n => n.Price)
                                       .ThenBy(n => n.Title)
                                       .Select(n => new
                                       {
                                           Autor = n.Author,
                                           Precio = n.Price,
                                           Titulo = n.Title
                                       })).ToList();

            //GridView1.DataSource = librosOrdenados.ToList();
            GridView1.DataSource = librosOrdenadosLambda;
            GridView1.DataBind();
        }
    }
}