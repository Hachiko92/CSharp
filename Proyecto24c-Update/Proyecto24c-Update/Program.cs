using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto24c_Update
{
    class Program
    {
        // metodo que crea un update por la tabla de Regiones 
        // (cambiar la descripcion de una region creada antes)
        private static void UpdateRegion(int regionId, string descripcion, string cadenaConexion)
        {
            string consulta = "UPDATE Region SET RegionDescription = @region WHERE RegionID = @codigo";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.Add("@codigo", SqlDbType.Int);
                comando.Parameters["@codigo"].Value = regionId;

                comando.Parameters.AddWithValue("@Region", descripcion);

                try
                {
                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();

                    Console.WriteLine("Filas afectadas: {0}", filasAfectadas);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        static void Main(string[] args)
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";

            Console.Write("Id de Región a modificar: ");
            int regionID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Descripcion de la región: ");
            string descripcionRegion = Console.ReadLine();

            UpdateRegion(regionID, descripcionRegion, cadenaConexion);

            Console.ReadKey();
        }
    }
}
