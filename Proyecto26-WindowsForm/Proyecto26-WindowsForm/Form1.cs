using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto26_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            lblMensaje1.Text = "Hola desde aquí";
            lblMensaje1.Visible = true;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCaja1.Text) > 20)
            {
                MessageBox.Show("Número mayor que 20", "CUIDADIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                lblResultado.Text = (Convert.ToInt32(txtCaja1.Text) + Convert.ToInt32(txtCaja2.Text)).ToString();
                lblResultado.Visible = true;
            }
        }

    }
}
