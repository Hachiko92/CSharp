using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP7_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UnidadesStock", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter parametro = new SqlParameter("@ProductID", SqlDbType.Int);
                    parametro.Value = Convert.ToInt32(txtProductID.Text);
                    command.Parameters.Add(parametro);

                    txtUnidades.Text = command.ExecuteScalar().ToString();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    txtUnidades.Text = ex.Message;
                }
            }
        }
    }
}