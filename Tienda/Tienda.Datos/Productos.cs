using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Datos
{
    public class Productos
    {
        public static DataTable cargarTabla()
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            string query = "SELECT * FROM Products";

            SqlDataAdapter adaptador = new SqlDataAdapter(query, cadenaConexion);

            DataTable table = new DataTable();
            adaptador.Fill(table);

            return table;
        }
    }
}
