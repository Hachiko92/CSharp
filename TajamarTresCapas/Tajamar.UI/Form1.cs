using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tajamar.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // ir a la BBDD y recuperar los empleados
                // comboBox1.valueMember = ...
                // comboBox1.displayMember = ...
                // cargar la combo

                DataTable tabla = Negocio.Empleado.recuperarTodosEmpleados(1);
                comboBox1.DisplayMember = tabla.Columns[1].ColumnName;
                comboBox1.ValueMember = tabla.Columns[0].ColumnName;
                comboBox1.DataSource = tabla;                
            }
        }
    }
}
