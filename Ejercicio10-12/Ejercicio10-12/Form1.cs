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

namespace Ejercicio10_12
{
    public partial class Form1 : Form
    {
        string cadenaConexion = @"Data Source=T06W09\sqlexpress;Initial Catalog=NORTHWND;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }
        
        private void cargarCombo()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    string query = "SELECT SupplierId, CompanyName FROM Suppliers";

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    DataRow fila = tabla.NewRow();
                    fila["CompanyName"].Equals(String.Empty);
                    fila["SupplierId"] = 0;
                    tabla.Rows.Add(fila);

                    cbProvedores.DisplayMember = tabla.Columns[1].ColumnName;
                    cbProvedores.ValueMember = tabla.Columns[0].ColumnName;

                    tabla.DefaultView.Sort = tabla.Columns[1].ColumnName;
                    cbProvedores.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void cargarGrid(int codigoProvedor)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    string query = 
                        "SELECT ProductName, QuantityPerUnit, UnitPrice, UnitsInStock FROM Products " +
                        "WHERE SupplierId = @codigo";

                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    SqlCommand comandoSelect = new SqlCommand(query, conexion);
                    comandoSelect.Parameters.AddWithValue("@codigo", codigoProvedor);
                    adaptador.SelectCommand = comandoSelect;

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
            Text = "Productos Provedores";
            cargarCombo();
        }

        private void cbProvedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(cbProvedores.SelectedValue);
            cargarGrid(valor);
        }
    }
}
