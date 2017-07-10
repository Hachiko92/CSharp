using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto46_LinqToSql
{
    public partial class WebForm7_SubmitChanges : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using(DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var empleado = db.Employees
                              .FirstOrDefault(em => em.EmployeeID.Equals(5));

                if (empleado != null)
                {
                    empleado.City = "Barcelona";
                    // submitChanges tiene por debajo una transición
                    db.SubmitChanges();
                }

                var empleado2 = db.Employees
                               .SingleOrDefault(em => em.EmployeeID == 6);
                
                if(empleado2 != null)
                {
                    db.Employees.DeleteOnSubmit(empleado2);
                    db.SubmitChanges();
                    //DeleteAllOnSubmit borra TODOS los elementos 
                }

                Employee empleadoNuevo = new Employee() { };
                //Cuando un valor se autoincrementa no tienes que ser puestos
                //empleadoNuevo.EmployeeID = 20;
                empleadoNuevo.City = "Madrid";

                db.Employees.InsertOnSubmit(empleadoNuevo);
                db.SubmitChanges();
            }
        }
    }
}