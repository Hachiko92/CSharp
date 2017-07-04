using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // rellena la DropDownList
                Cargar_Combo();
            }
        }

        protected void drpProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(drpProductos.SelectedItem.Value);
            /* hace las operaciones sobre la base de datos */
            Cargar_Datos(id);
        }

        private void Cargar_Combo()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;
            string query = "SELECT ProductID, ProductName FROM Products";

            /* conexion a la base de datos */
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    /* Declaración SQL */
                    SqlCommand comandoSelect = new SqlCommand(query, connection);

                    /* Creacción del lector, que lee linea linea la tabla resultante de la query */
                    SqlDataReader lector = comandoSelect.ExecuteReader();

                    while (lector.Read())
                    {
                        ListItem elemento = new ListItem();
                        /* El usuario visualiza el nombre del producto */
                        elemento.Text = lector["ProductName"].ToString();
                        /* El valor será igual al ID del producto */
                        elemento.Value = lector["ProductID"].ToString();
                        drpProductos.Items.Add(elemento);
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }

        private void Cargar_Datos (int id)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;

            /* conexion a la base de datos */
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    /* Procedimiento almacenado */
                    SqlCommand comando = new SqlCommand("MostExpensive", connection);
                    comando.CommandType = CommandType.StoredProcedure;

                    /* Declaración de los parametros */
                    SqlParameter parametro = new SqlParameter();
                    parametro.ParameterName = "@IDProducto";
                    parametro.Value = id;
                    parametro.SqlDbType = SqlDbType.Int;
                    comando.Parameters.Add(parametro);

                    /* ExecuteScalar devuelve un solo valor */
                    txtPrecio.Text = comando.ExecuteScalar().ToString();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);/* */
                }
            }
        }
    }
}