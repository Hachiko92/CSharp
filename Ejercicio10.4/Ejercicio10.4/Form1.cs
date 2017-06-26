using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2();

            formulario2.carga_nombre(txtNombre.Text, txtApellido.Text);
            formulario2.carga_dias(Convert.ToInt32(txtEdad.Text));

            formulario2.Show();
        }
    }
}
