using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajamar.Datos
{
    public class Empleado
    {
        public static DataTable recuperarTodosEmpleados()
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            string query = "SELECT EmployeeId as [Codigo empleado], LastName + ' ' + FirstName AS Empleado FROM Employees";

            SqlDataAdapter adaptador = new SqlDataAdapter(query, cadenaConexion);

            DataTable table = new DataTable();
            adaptador.Fill(table);

            return table;
        }
    }
}
