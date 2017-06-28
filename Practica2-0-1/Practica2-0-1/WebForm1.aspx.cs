using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica2_0_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] nums = new int[] { 0, 4, 2, 6, 3, 8, 3, 1 };

            var lista = from n in nums
                        where n < 5
                        orderby n ascending
                        select n;

            result.InnerHtml = "";
            foreach (int n in lista)
            {
                result.InnerHtml += n + "<br>";
            }

            //var resultLambda = nums.Where(n => n < 5).OrderBy(n => n);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int[] nums = new int[] { 0, 4, 2, 6, 3, 8, 3, 1 };

            result.InnerHtml = nums.Sum().ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int[] nums = new int[] { 0, 4, 2, 6, 3, 8, 3, 1 };

            var lista = from n in nums.Distinct()
                        where (n < 5)
                        orderby n ascending
                        select n;

            var lista2 = (from n in nums
                          where (n < 5)
                          orderby n ascending
                          select n).Distinct();

            result.InnerHtml = "";
            foreach (int n in lista)
            {
                result.InnerHtml += n + "<br>";
            }

            //var restultLambda = nums.Where(n => n < 5).Distinct();
        }
    }
}