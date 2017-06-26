using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable tabla = Negocio.Productos.cargarTabla();

            dataGridView1.DataSource = tabla;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Convert.ToInt32(dataGridView1.CurrentRow.Cells["UnitsInStock"].Value) > 50)
            {
                txtProducto.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
                txtQuantity.Text = dataGridView1.CurrentRow.Cells["QuantityPerUnit"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Cantidad en stock insuficiente", "Error");
            }
        }
    }
}
