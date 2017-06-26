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

namespace Ejercicio10_13
{
    public partial class Form1 : Form
    {
        string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            Text = "Employees";
        }

        private void cargarTabla()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    string query = "SELECT * FROM Employees";

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dataGridView1.DataSource = tabla;

                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtApellido.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
            txtNombre.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
            txtTitle.Text = dataGridView1.CurrentRow.Cells["Title"].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            txtCity.Text = dataGridView1.CurrentRow.Cells["City"].Value.ToString();
            txtPC.Text = dataGridView1.CurrentRow.Cells["PostalCode"].Value.ToString();
            txtCountry.Text = dataGridView1.CurrentRow.Cells["Country"].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells["HomePhone"].Value.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form2 formCV = new Form2();
            string notes = dataGridView1.CurrentRow.Cells["Notes"].Value.ToString();
            formCV.mostrarCV(notes);
            formCV.Show();
        }
    }
}
