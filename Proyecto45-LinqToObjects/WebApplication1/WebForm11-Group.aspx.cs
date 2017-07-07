using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* agrupar por titulos y por editores */
            /* las columnas pueden ser solo con los objetos que ha agrupados */
            var query = from book in SampleData.Books
                        group book by new { book.Publisher, book.Subject }
                        into grouping
                        select new
                        {
                            Publisher = grouping.Key.Publisher.Name,
                            Subject = grouping.Key.Subject.Name
                        };

            var queryLambda = SampleData.Books
                             .GroupBy(book => new { book.Publisher, book.Subject })
                             .Select(book => new
                             {
                                 Publisher = book.Key.Publisher.Name,
                                 Subject = book.Key.Subject.Name
                             });

            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }
    }
}