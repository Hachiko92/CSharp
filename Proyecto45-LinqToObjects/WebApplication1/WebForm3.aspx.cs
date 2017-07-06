using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] books = { "Linq to Sql", "Sql in Action", "Asp for All", "Linq for Dummies" };

            /* .ToList() porque el GridView se espera una lista */
            GridView1.DataSource = (from book in books
                                   where book.Length > 14
                                   orderby book
                                   select book.ToUpper()).ToList();
            GridView1.DataBind();
        }
    }
}