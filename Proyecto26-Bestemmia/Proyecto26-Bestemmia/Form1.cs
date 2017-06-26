using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto26_Bestemmia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCaja1.Text) > 20)
            {
                MessageBox.Show("Número mayor que 20", "CUIDADIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                lblMensaje.Text = (Convert.ToInt32(txtCaja1.Text) + Convert.ToInt32(txtCaja2.Text)).ToString();
                lblMensaje.Visible = true;
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCaja1.Text))
            {
                if(!Regex.IsMatch(txtCaja1.Text, @"[\p{L}\s]"))
                {
                    MessageBox.Show("Formato Correcto");
                }
                else
                {
                    MessageBox.Show("No es un número");
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar la caja");
            }

            //lblMensaje.Text = (Convert.ToInt32(txtCaja1.Text) - Convert.ToInt32(txtCaja2.Text)).ToString();
            //lblMensaje.Visible = true;
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Hola desde aquí";
            lblMensaje.Visible = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado =
                MessageBox.Show("¿Quieres borrar el registro empleado?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (resultado.Equals(DialogResult.OK))
            {
                MessageBox.Show("Borrando registro");
            }
            else
            {
                MessageBox.Show("back");
            }
        }
    }
}


