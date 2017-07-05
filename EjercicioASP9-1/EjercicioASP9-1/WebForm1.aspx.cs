using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioASP9_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void drpEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dvSql = (DataView)sqlEmployees.Select(DataSourceSelectArguments.Empty);

            foreach (DataRowView row in dvSql)
            {
                this.txtId.Text = row["EmployeeId"].ToString();
                this.txtNombre.Text = row["FirstName"].ToString();
                this.txtApellido.Text = row["LastName"].ToString();
                this.txtCargo.Text = row["Title"].ToString();
            }
        }

        protected void drpCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            drpEmployees.Items.Clear();
            drpEmployees.Items.Add(" - Selecciona un Cliente - ");
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCargo.Text = "";
        }
    }
}