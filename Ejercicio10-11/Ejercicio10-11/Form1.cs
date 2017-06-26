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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            string select = "SELECT * FROM Customers WHERE Country = @pais";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter();

                    SqlCommand comandoSelect = new SqlCommand(select, conexion);
                    comandoSelect.Parameters.AddWithValue("@pais", "Germany");

                    adaptador.SelectCommand = comandoSelect;

                    DataTable tabla = new DataTable();
                    /* el adaptador rellena la tabla */
                    adaptador.Fill(tabla);

                    dataGridView1.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Form2 formulario2 = new Form2();

            formulario2.cargarCombo(codigo);

            formulario2.Show();
        }
    }
}
