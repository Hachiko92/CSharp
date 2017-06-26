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

namespace Ejercicio10_9
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
            string query = "SELECT CompanyName, ContactName FROM Customers WHERE City = @ciudad";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
       

                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    SqlCommand comandoSelect = new SqlCommand(query, conexion);

                    SqlParameter parametro = comandoSelect.Parameters.AddWithValue("@ciudad", "Berlin");
                    DataTable tabla = new DataTable();

                    adaptador.SelectCommand = comandoSelect;
                    adaptador.Fill(tabla);

                    dataGridView1.DataSource = tabla;
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCompania.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtContacto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCompania.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtContacto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
