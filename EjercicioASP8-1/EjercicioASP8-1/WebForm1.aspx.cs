using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP8_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "SELECT ContactName, Address FROM Customers WHERE City = 'London' ORDER BY ContactName";

            DataSet data = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(query, ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString);

            adaptador.Fill(data);

            DataTableReader reader = data.CreateDataReader();

            while (reader.Read())
            {
                Response.Write("<strong>" + reader["ContactName"] + ":</strong> " + reader["Address"] + "<hr>");
            }

            reader.Close();
        }
    }
}