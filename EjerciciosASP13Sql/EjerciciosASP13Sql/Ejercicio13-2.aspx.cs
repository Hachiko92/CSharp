using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjerciciosASP13Sql
{
    public partial class Ejercicio13_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var employees = from em in db.Employees
                                where em.City == "London"
                                orderby em.BirthDate
                                select new
                                {
                                    Nombre = em.FirstName + " " + em.LastName,
                                    Fecha = em.BirthDate
                                };

                DataList1.DataSource = employees;
                DataList1.DataBind();
            }
        }
    }
}