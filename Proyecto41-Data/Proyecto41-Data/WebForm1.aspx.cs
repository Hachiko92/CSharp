using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto41_Data
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;
            string query = "SELECT ContactName, Country FROM Customers";

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                connection.Open();

                SqlDataAdapter adaptador = new SqlDataAdapter(query, connection);
                DataSet customersDS = new DataSet();
                adaptador.Fill(customersDS, "Customers");
                DataView customersDV = new DataView(customersDS.Tables["Customers"], "Country = 'USA'", "ContactName DESC", DataViewRowState.CurrentRows);

                Response.Write("Clientes de los USA <br><br>");
                foreach (DataRowView filaVista in customersDV)
                {
                    DataRow fila = filaVista.Row;
                    Response.Write(fila[0].ToString() + "<br>");
                }

                connection.Close();
            }
        }
    }
}