using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioEF1_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Crear_Empleados();
            Cargar_Grid();
        }

        private void Crear_Empleados()
        {
            using (var context = new Model1Container())
            {
                var person = new Empleado
                {
                    IdEmpleado = 1,
                    Nombre = "Roberto",
                    Apellido = "Rossi"
                };
                context.EmpleadoSet.Add(person);

                var person1 = new Empleado
                {
                    IdEmpleado = 2,
                    Nombre = "Allen",
                    Apellido = "Marks"
                };
                context.EmpleadoSet.Add(person1);

            }
        }

        private void Cargar_Grid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("DNI");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");

            using(var context = new Model1Container())
            {
                var query = from c in context.EmpleadoSet
                            select new
                            {
                                codEmpleado = c.IdEmpleado
                            };

                GridView1.DataSource = query;
                GridView1.DataBind();

                //foreach (var empleado in context.EmpleadoSet)
                //{
                //    Crear_Fila(dt, empleado.IdEmpleado, empleado.Nombre, empleado.Apellido, empleado.DNI);
                //}
            }
            
        }

        private void Crear_Fila(DataTable dt, int idEmpleado, string Nombre, string Apellido, string DNI)
        {
            DataRow fila;
            fila = dt.NewRow();

            //fila["ID"] 
        }
    }
}