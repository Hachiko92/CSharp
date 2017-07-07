using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var minPrice = Books.GetBooks()
                          .Min(book => book.Price);
            var minPrice1 = (from book in Books.GetBooks()
                             select book.Price)
                             .Min();
            txtMinimo.Text = minPrice.ToString();

            var maxPrice = Books.GetBooks()
                          .Max(book => book.Price);
            var maxPrice1 = (from book in Books.GetBooks()
                             select book.Price)
                             .Max();
            txtMaximo.Text = maxPrice.ToString();

            var total = Books.GetBooks()
                       .Sum(book => book.Price);
            var total1 = (from book in Books.GetBooks()
                          select book.Price)
                          .Sum();
            txtTotal.Text = total.ToString();

            var librosBaratos = Books.GetBooks()
                               .Where(book => book.Price < 300)
                               .Count();
            var librosBaratos1 = (from book in Books.GetBooks()
                                  select book.Price < 300)
                                  .Count();
            txtBarato.Text = librosBaratos.ToString();
        }
    }
}