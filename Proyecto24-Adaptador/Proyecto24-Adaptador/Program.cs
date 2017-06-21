using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto24_Adaptador
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            string select = "SELECT * FROM Customers WHERE Country = @country AND City = @city";
            string insert = "INSERT INTO Customers (CustomerId, CompanyName) VALUES (@customerID, @companyName)";
            string update = "UPDATE Customers SET CompanyName = @companyName WHERE CustomerId = @oldCustomerId";
            string delete = "DELETE FROM Customers WHERE CustomerId = @CustomerID";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    ///* Select */
                    //SqlCommand commandSelect = new SqlCommand(select, connection);
                    //commandSelect.Parameters.AddWithValue("@country", "Argentina");
                    //commandSelect.Parameters.AddWithValue("@city", "Buenos Aires");

                    //adaptador.SelectCommand = commandSelect;

                    //SqlDataReader lector = commandSelect.ExecuteReader();

                    //while (lector.Read())
                    //{
                    //    Console.WriteLine("{0}: {1}", lector[0], lector[1]);
                    //}

                    ///* Insert */
                    //SqlCommand commandInsert = new SqlCommand(insert, connection);
                    //commandInsert.Parameters.AddWithValue("@customerID", "PIPAS");
                    //commandInsert.Parameters.AddWithValue("@companyName", "Piprei Astri");
                    //adaptador.InsertCommand = commandInsert;

                    //int filasInsertadas = adaptador.InsertCommand.ExecuteNonQuery();
                    //Console.WriteLine("Filas insertadas: {0}", filasInsertadas);

                    ///* Update */
                    //SqlCommand commandUpdate = new SqlCommand(update, connection);
                    //commandUpdate.Parameters.AddWithValue("@companyName", "Una nueva compañia");
                    //commandUpdate.Parameters.AddWithValue("@oldCustomerId", "PIPAS");
                    //adaptador.UpdateCommand = commandUpdate;

                    //int filasActualizadas = adaptador.UpdateCommand.ExecuteNonQuery();
                    //Console.WriteLine("Filas actualizadas: {0}", filasActualizadas);

                    /* Delete */
                    SqlCommand commandDelete = new SqlCommand(delete, connection);
                    // objeto proprio para manejar los datos
                    SqlParameter parameter = commandDelete.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 15);
                    parameter.Value = "PIPAS";
                    adaptador.DeleteCommand = commandDelete;

                    int filasBorradas = adaptador.DeleteCommand.ExecuteNonQuery();
                    Console.WriteLine("Filas eliminadas: {0}", filasBorradas);

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
