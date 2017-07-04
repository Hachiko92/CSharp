using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto39_ADONET
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conexion = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;
            //string query = "SELECT * FROM EMPLOYEES";
            string categoryName = "Beverages";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                try
                {
                    connection.Open();
                    
                    //SqlCommand comando = new SqlCommand(query, connection);
                    SqlCommand comando = new SqlCommand("SalesByCategory", connection);
                    comando.CommandType = CommandType.StoredProcedure;

                    SqlParameter parametro = new SqlParameter();
                    //parametro.ParameterName = "@Category";
                    //parametro.DbType = DbType.Int32;
                    /* por defecto sabe que es input */
                    //parametro.Direction = ParameterDirection.Input;

                    //parametro.ParameterName = "@nClientes";
                    //parametro.Direction = ParameterDirection.Output;

                    parametro.ParameterName = "@CategoryName";
                    parametro.SqlDbType = SqlDbType.NVarChar;
                    parametro.Value = categoryName.ToString();

                    comando.Parameters.Add(parametro);

                    /* devuelve el numero de registros encontrados */
                    int cantidad = comando.ExecuteNonQuery();

                    connection.Close();

                    Response.Write(cantidad);
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }
    }
}