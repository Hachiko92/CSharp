using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] words = { "hola", "adios", "buenas", "noches" };

            foreach (string word in words)
            {
                if(word.Length <= 5)
                {
                    Response.Write(word + "<br>");
                }
            }

            Response.Write("<br>Con Linq: <br>");

            var shortWord = from word in words
                            where word.Length <= 5
                            select word;

            foreach (var word in shortWord)
            {
                Response.Write(word + "<br>");
            }
        }
    }
}