using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            string consulta = "SELECT ProductID, ProductName FROM Products ORDER BY ProductID";
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlDataAdapter daProductos = new SqlDataAdapter(consulta, connection);

                    DataSet dsEmpresa = new DataSet("Empresa");

                    daProductos.Fill(dsEmpresa, "Productos");

                    DataTable tblProductos = dsEmpresa.Tables["Productos"];
                    Console.WriteLine("LISTADO DE PRODUCTOS:\n");

                    foreach (DataRow fila in tblProductos.Rows)
                    {
                        Console.WriteLine("Número: \t{0}", fila[0]);
                        Console.WriteLine("Producto: \t{0}\n", fila[1]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }

            }

            Console.ReadKey();
        }
    }
}
