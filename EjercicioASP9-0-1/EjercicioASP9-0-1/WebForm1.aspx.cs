using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP9_0_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;
            string query = "SELECT * FROM Products WHERE Discontinued = @Descuento";

            using(SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adaptador.SelectCommand.Parameters.AddWithValue("@Descuento", rbDescuento.SelectedValue);
                adaptador.Fill(dt);

                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
        }
    }
}