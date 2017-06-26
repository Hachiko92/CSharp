using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto25
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            string query = "SELECT E.LastName + ' ' + E.FirstName as Nombre, E.Address , E.city " +
                "FROM Employees AS E WHERE City = @ciudad";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@ciudad", "London");

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = comando;
                    SqlDataReader lector = comando.ExecuteReader();

                    StreamWriter fichero;
                    fichero = File.CreateText("empleados.txt");

                    while (lector.Read())
                    {
                        fichero.WriteLine(lector["Nombre"].ToString() + " (" + lector["Address"].ToString() + ") " + lector["City"].ToString());
                    }

                    fichero.Close();
                    lector.Close();
                    conexion.Close();
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Datos transferido con éxito, pulse intro para continuar");
            Console.ReadKey();
        }
    }
}
