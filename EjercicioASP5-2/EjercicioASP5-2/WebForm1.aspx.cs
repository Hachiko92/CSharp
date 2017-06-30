using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP5_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public double asignatura1
        {
            get
            {
                return Convert.ToDouble(txtAsignatura1.Text);
            }
        }
        public double asignatura2
        {
            get
            {
                return Convert.ToDouble(txtAsignatura2.Text);
            }
        }
        public double asignatura3
        {
            get
            {
                return Convert.ToDouble(txtAsignatura3.Text);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}