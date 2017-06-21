using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto24d_DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";

            // siempre utilizar el "using" y el "try catch"
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            conexion.Open();
            // daEmpleados -> da = Data Adapters
            SqlDataAdapter daEmpleados = new SqlDataAdapter("SELECT * FROM Employees", conexion);
            
            // dsEmpresa -> ds = Data Set
            DataSet dsEmpresa = new DataSet("Empresa");

            daEmpleados.Fill(dsEmpresa, "Empleados");

            DataTable tblEmpleados = dsEmpresa.Tables["Empleados"];

            foreach(DataRow fila in tblEmpleados.Rows)
            {
                Console.WriteLine("{0}\t{1}", fila[0], fila[1]);
            }

            Console.ReadKey();
        }
    }
}
