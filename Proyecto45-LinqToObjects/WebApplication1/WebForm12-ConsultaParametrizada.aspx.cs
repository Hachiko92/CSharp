using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm12_ConsultaParametrizada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int minPageCount = 200;

            var books = from book in SampleData.Books
                        where book.PageCount >= minPageCount
                        select book;
        }
    }
}