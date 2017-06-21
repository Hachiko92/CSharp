using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            StringBuilder query = new StringBuilder("SELECT OD.OrderID, OD.ProductID, P.ProductName, OD.Discount");
            query.Append(" FROM Products AS P INNER JOIN[Order Details] AS OD ON OD.ProductID = P.ProductID");
            query.Append(" WHERE OD.Discount > @descuento");
            query.Append(" ORDER BY P.ProductName");

            string select = query.ToString();

            using(SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter();

                    SqlCommand comandoSelect = new SqlCommand(select, conexion);
                    SqlParameter parametro = comandoSelect.Parameters.Add("@descuento", SqlDbType.Real);
                    parametro.Value = 0.1;

                    adaptador.SelectCommand = comandoSelect;

                    SqlDataReader lector = comandoSelect.ExecuteReader();

                    Console.WriteLine("Productos descuentados minimo al 10%");
                    Console.WriteLine("-----------------------------------------------\n");

                    while (lector.Read())
                    {
                        //Console.WriteLine("{0}\t{1}\t{2}\t{3}", lector[0], lector[1], lector[2], lector[3]);
                        Console.WriteLine("Codigo de factura: {0}", lector[0]);
                        Console.WriteLine("Codigo producto: {0}", lector[1]);
                        Console.WriteLine("Nombre Producto: {0}", lector[2]);
                        Console.WriteLine("Descuento: {0}\n", lector[3]);
                        Console.WriteLine("-----------------------------------------------\n");
                    }

                    conexion.Dispose();
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
