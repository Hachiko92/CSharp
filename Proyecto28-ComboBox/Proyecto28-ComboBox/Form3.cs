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

namespace Proyecto28_ComboBox
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            string cadena = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";
            string query = "SELECT * FROM Employees WHERE City = 'London'";

            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dataGridView1.DataSource = tabla;
                dataGridView1.AutoResizeColumns( DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
            /* para ver el contenido de la celda misma*/
            //string nombreSeleccionado = dataGridView1.CurrentCell.Value.ToString();

            MessageBox.Show(nombre);
        }
    }
}
