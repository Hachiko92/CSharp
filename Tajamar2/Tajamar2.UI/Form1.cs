using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tajamar2.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Negocio.Producto.obtenerProductos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            DataTable tabla = Negocio.Producto.obtenerProductyCantidad(id);

            if(tabla != null)
            {
                textBox1.Text = tabla.Rows[0][0].ToString();
                textBox2.Text = tabla.Rows[0][1].ToString();
            }
            else
            {
                MessageBox.Show("Stock Insuficiente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
