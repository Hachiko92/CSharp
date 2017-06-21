using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto24b_Databases
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            string consulta =
                "SELECT ProductID, ProductName, UnitPrice FROM Products" +
                " WHERE UnitPrice > @precio AND UnitsInStock = @unidades ORDER BY UnitPrice DESC";
            //int paramValue = 50;

            Console.Write("Precio minimo: ");
            int paramValue1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unidades en stock: ");
            int paramValue2 = Convert.ToInt32(Console.ReadLine());

            // gracias a using cuando se acaban las operaciones con el database se limpian todas las
            // cosas utilizada 
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                // AddWithValue se utiliza cuando la consulta solo va a leer los datos
                comando.Parameters.AddWithValue("@precio", paramValue1);
                comando.Parameters.AddWithValue("@unidades", paramValue2);

                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2:F2}", lector[0], lector[1], lector[2]);
                    }

                    lector.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadKey();
            }

        }
    }
}
