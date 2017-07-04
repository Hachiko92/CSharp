using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP7_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCombo();
            }
        }

        //protected void btnAceptar_Click(object sender, EventArgs e)
        //{
        //    CargarDatos();
        //}

        private void CargarCombo()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;
            string query = "SELECT DISTINCT Country FROM Customers";
            int i = 0;

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    SqlCommand comandoSelect = new SqlCommand(query, connection);

                    SqlDataReader lector = comandoSelect.ExecuteReader();

                    while (lector.Read())
                    {
                        ListItem elemento = new ListItem();
                        elemento.Text = lector["Country"].ToString();
                        /* en este caso no sería necesario tener el valor de atrás diferente a lo que está adelante */
                        elemento.Value = i.ToString();
                        drpPaises.Items.Add(elemento);

                        i++;
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    txtClientes.Text = ex.Message;
                }
            }
        }

        private void CargarDatos(string pais)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("ClientesPorPais", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter parametro = new SqlParameter("@Pais", SqlDbType.NVarChar);
                    parametro.Value = pais.ToString();
                    command.Parameters.Add(parametro);

                    txtClientes.Text = command.ExecuteScalar().ToString();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    txtClientes.Text = ex.Message;
                }
            }
        }

        protected void drpPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = drpPaises.SelectedItem.ToString();
            CargarDatos(valor);
        }
    }
}