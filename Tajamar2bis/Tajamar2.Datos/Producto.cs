using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tajamar2.Datos
{
    public class Producto
    {
        public static DataTable obtenerProductos()
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            string query = "SELECT * FROM Products";

            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(query, cadenaConexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public static DataTable ObtenerProductoyCantidad(int idProducto)
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            string query = "SELECT ProductName, QuantityPerUnit, UnitsInStock FROM Products WHERE ProductId = " + idProducto;

            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(query, cadenaConexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}
