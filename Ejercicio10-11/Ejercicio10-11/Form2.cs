using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10_11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void cargarCombo(string codigo)
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            string query = "SELECT OrderId, Freight FROM Orders WHERE CustomerId = @codigo";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter();

                    SqlCommand comandoSelect = new SqlCommand(query, conexion);
                    comandoSelect.Parameters.AddWithValue("@codigo", codigo);

                    adaptador.SelectCommand = comandoSelect;

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    /* la tabla se ordena de modo ascendente por la columna 1, el "Freight" */
                    tabla.DefaultView.Sort = tabla.Columns[1].ColumnName;

                    cbFreight.DisplayMember = tabla.Columns[1].ColumnName;
                    cbFreight.ValueMember = tabla.Columns[0].ColumnName;

                    cbFreight.DataSource = tabla;
                    /* cbFreight.Items.Count devuelve el numero de elementos, asì el comboBox
                     * por defecto me selecciona el ultimo elemento (devuelve el primero (??)) */
                    cbFreight.SelectedItem = (cbFreight.Items.Count - 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void cbFreight_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOrder.Text = cbFreight.SelectedValue.ToString();
            txtFreight.Text = cbFreight.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
        }
    }
}
