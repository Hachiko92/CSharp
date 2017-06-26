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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string cadena = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";


            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand();
                SqlDataReader dt;

                dataGridView1.ColumnCount = 3;
                dataGridView1.ColumnHeadersVisible = true;

                DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                columnHeaderStyle.BackColor = Color.Aquamarine;
                columnHeaderStyle.Font = new Font("verdana", 10, FontStyle.Bold);

                dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

                dataGridView1.Columns[0].Name = "idEmpleado";
                dataGridView1.Columns[1].Name = "Nombre";
                dataGridView1.Columns[2].Name = "Apellido";

                comando.Connection = conexion;
                /* Se debe siempre poner la variable a través de un parametro */
                comando.CommandText = "SELECT * FROM Employees WHERE City = 'London'";
                comando.CommandType = CommandType.Text;
                conexion.Open();

                /* Rows.Clear es por si es la segunda vex que se executa */
                dataGridView1.Rows.Clear();
                dt = comando.ExecuteReader();

                while (dt.Read())
                {
                    int linea = dataGridView1.Rows.Add();

                    dataGridView1.Rows[linea].Cells["idEmpleado"].Value = dt.GetInt32(dt.GetOrdinal("EmployeeId")).ToString();
                    dataGridView1.Rows[linea].Cells["Nombre"].Value = dt.GetString(dt.GetOrdinal("FirstName")).ToString();
                    dataGridView1.Rows[linea].Cells["Apellido"].Value = dt.GetString(dt.GetOrdinal("LastName")).ToString();
                }

            }
        }
    }
}
