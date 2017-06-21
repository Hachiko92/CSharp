using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto24_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion = @"Data Source = T06W09\sqlexpress; Initial Catalog = NORTHWND; Integrated Security = True";
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT * FROM Customers", conexion);

            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                //Console.WriteLine("{0} {1}", lector["CustomerID"], lector["CompanyName"]);
                //Console.WriteLine("{0} {1}", lector[0], lector[1]);
                //Console.WriteLine(String.Format("{0} {1}", lector["CustomerID"], lector["CompanyName"]));
                Console.WriteLine(String.Format("{0} {1}", lector[0], lector[1]));
            }

            Console.ReadKey();
        }
    }
}
