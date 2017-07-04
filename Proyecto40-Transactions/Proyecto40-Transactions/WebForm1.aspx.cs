using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Transactions;

namespace Proyecto40_Transactions
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            GenerarTransaccion();
        }

        private void GenerarTransaccion()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["NorthWind"].ConnectionString;
            string queryActualizar, queryBorrar;
            queryActualizar = "UPDATE Products SET UnitPrice = UnitPrice + 2 WHERE UnitsInStock > 20";
            queryBorrar = "DELETE FROM Customers WHERE Country='" + txtPais.Text + "'";

            try
            {
                using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
                {
                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    {
                        conexion.Open();
                        SqlCommand comando = new SqlCommand(queryActualizar, conexion);
                        int registrosAfectados = comando.ExecuteNonQuery();
                        Response.Write("Registros actualizados: " + registrosAfectados + "<br>");
                    }

                    using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                    {
                        conexion.Open();

                        SqlCommand comando = new SqlCommand(queryBorrar, conexion);
                        int registrosAfectados = comando.ExecuteNonQuery();
                        Response.Write("Registros borrados: " + registrosAfectados + "<br>");
                    }

                    ts.Complete();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}