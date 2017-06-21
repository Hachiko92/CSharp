using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            string delete = "DELETE FROM [Order Details] WHERE ProductID IN (SELECT ProductID FROM Products WHERE ProductName = @producto)";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter();

                    SqlCommand comandoDelete = new SqlCommand(delete, conexion);
                    SqlParameter parametro = comandoDelete.Parameters.Add("@producto", SqlDbType.NVarChar, 15);
                    parametro.Value = "Pavlova";

                    adaptador.SelectCommand = comandoDelete;
                    int lineasBorradas = adaptador.SelectCommand.ExecuteNonQuery();

                    Console.WriteLine("Lineas borradas: {0}", lineasBorradas);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
