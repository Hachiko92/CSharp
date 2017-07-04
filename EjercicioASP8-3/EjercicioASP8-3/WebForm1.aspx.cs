using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP8_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;
            string query = "SELECT ProductName, UnitsInStock FROM Products";

            try
            {
                using(SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, connection);
                    DataSet productosDS = new DataSet();
                    /* copia los resultados de la query en una copia virtual */
                    adaptador.Fill(productosDS, "Products");

                    DataView productosDV = new DataView(productosDS.Tables[0], "UnitsInStock > 50", "ProductName", DataViewRowState.CurrentRows);

                    Response.Write("<strong>Productos con mas de 50 unidades in stock:</strong><br><br><ol>");
                    foreach (DataRowView lineaDV in productosDV)
                    {
                        DataRow fila = lineaDV.Row;
                        Response.Write("<li>" + lineaDV[0].ToString() + "<strong> " + lineaDV[1].ToString() + "</strong></li>");
                    }
                    Response.Write("</ol>");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}