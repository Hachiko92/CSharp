using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GridView1.DataSource = from publisher in SampleData.Publishers
            //                       join book in SampleData.Books
            //                       on publisher equals book.Publisher
            //                       select new
            //                       {
            //                           Editoriales = publisher.Name,
            //                           Libros = book.Title
            //                       };

            //GridView1.DataSource = SampleData.Publishers
            //                      .Join(SampleData.Books, publisher => publisher, book => book.Publisher, (publisher, book) => new
            //                      {
            //                          Editor = publisher.Name,
            //                          Libro = book.Title
            //                      });

            /* JOIN Izquierda */
            GridView1.DataSource = from publisher in SampleData.Publishers
                                   join book in SampleData.Books
                                   on publisher equals book.Publisher
                                   into publisherBooks
                                   from book in publisherBooks.DefaultIfEmpty()
                                   select new
                                   {
                                       Editor = publisher.Name,
                                       Libro = book == default(Book) ? "No hay libro" : book.Title
                                   };

            GridView1.DataBind();
        }
    }
}