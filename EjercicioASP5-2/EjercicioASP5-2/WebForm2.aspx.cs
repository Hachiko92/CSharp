﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP5_2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                double asignatura1 = PreviousPage.asignatura1;
                double asignatura2 = PreviousPage.asignatura2;
                double asignatura3 = PreviousPage.asignatura3;

                double media = mediaTresNumeros(asignatura1, asignatura2, asignatura3);
                txtMedia.Text = media.ToString();
            }
            else
            {
                Response.Write("De que no");
            }
        }

        public double mediaTresNumeros (double n1, double n2, double n3)
        {
            double media = (n1 + n2 + n3) / 3;
            return media;
        }
    }
}