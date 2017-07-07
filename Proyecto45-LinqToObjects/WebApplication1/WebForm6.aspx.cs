using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var books = Books.GetBooks()
            //           .Select((book, index) => new
            //           {
            //               index,
            //               book.Title
            //           })
            //           .OrderBy(book => book.Title);

            var books = Books.GetBooks()
                       .Select((book, pepe) => new
                       {
                           pepe,
                           book.Title,
                           book.Price
                       })
                       .OrderBy(book => book.Title);

            GridView1.DataSource = books;
            GridView1.DataBind();

        }
    }
}