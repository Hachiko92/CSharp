using CursoLinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GridViewComplete.DataSource = SampleData.Books
                                        .Select((book, index) => new
                                        {
                                            Index = index,
                                            Book = book.Title
                                        });

                GridViewComplete.DataBind();

                int count = SampleData.Books.Count();

                for (int i = 0; i < count; i++)
                {
                    ddlStart.Items.Add(i.ToString());
                    ddlEnd.Items.Add(i.ToString());
                }

                ddlStart.SelectedIndex = 0;
                ddlEnd.SelectedIndex = count - 1;

                DisplayPartialData();
            }
        }

        protected void ddlStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPartialData();
        }

        protected void ddlEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPartialData();
        }

        private void DisplayPartialData()
        {
            int startIndex = int.Parse(ddlStart.SelectedValue);
            int endIndex = int.Parse(ddlEnd.SelectedValue);

            GridViewPartial.DataSource = SampleData.Books
                                          .Select((book, index) => new
                                          {
                                              Index = index,
                                              Book = book.Title
                                          })
                                          .Skip(startIndex)
                                          .Take(endIndex - startIndex + 1);

            GridViewPartial.DataBind();
        }
    }
}