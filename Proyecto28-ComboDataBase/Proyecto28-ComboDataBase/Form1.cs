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

namespace Proyecto28_ComboDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }

        private void cargarCombo()
        {
            string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";

            SqlConnection conexion = new SqlConnection(cadenaConexion);
            string selectCommand = "SELECT CategoryId, CategoryName FROM Categories";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);

            /* Cuando hacemos una combo siempre hay que poner un valor adelante y uno despues */
            DataRow fila = tabla.NewRow();
            fila["CategoryName"] = string.Empty;
            fila["CategoryId"] = 0;
            tabla.Rows.Add(fila);

            tabla.DefaultView.Sort = tabla.Columns[1].ColumnName;

            /* displayMember es lo que tiene adelante, lo que muestra */
            comboBox1.DisplayMember = tabla.Columns[1].ColumnName;
            /* ValueMembere es lo que selecciona de verdad */
            comboBox1.ValueMember = tabla.Columns[0].ColumnName;
            comboBox1.DataSource = tabla;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = comboBox1.SelectedValue.ToString();
            //string valor = comboBox1.Text;

            textBox1.Text = valor;
        }
    }
}
