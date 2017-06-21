using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            string update = "UPDATE Products SET UnitPrice += ((UnitPrice/100)*@percentual)";
            string select = "SELECT ProductID, ProductName FROM Products WHERE UnitPrice > @cantidad";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter();

                    SqlCommand comandoUpdate = new SqlCommand(update, connection);
                    SqlParameter parametros = comandoUpdate.Parameters.Add("@percentual", SqlDbType.Int);
                    parametros.Value = 2;

                    adaptador.UpdateCommand = comandoUpdate;
                    int filasModificadas = adaptador.UpdateCommand.ExecuteNonQuery();

                    Console.WriteLine("Filas modificadas: {0}", filasModificadas);

                    SqlCommand comandoSelect = new SqlCommand(select, connection);
                    SqlParameter parametrosSelect = comandoSelect.Parameters.Add("@cantidad", SqlDbType.Int);
                    parametrosSelect.Value = 50;

                    SqlDataReader lector = comandoSelect.ExecuteNonQuery();
                    Console.WriteLine("");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadLine();
            }
        }
    }
}
