using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP2_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<int> lista = new List<int>();
            lista.Add(24);
            lista.Add(5);
            lista.Add(2);
            lista.Add(65);
            lista.Add(33);

            //var data = from n in lista
            //           where n == 2
            //           select n;

            /* cuando tienes dudas si existe o no se utiliza un FirstOrDefault */
            var data1 = (from n in lista
                         where n == 2
                         select n).FirstOrDefault();

            //var operacion = from n in lista
            //                select n;

            //int suma = operacion.Sum();

            int suma = (from n in lista
                    select n).Sum();

        }
    }
}