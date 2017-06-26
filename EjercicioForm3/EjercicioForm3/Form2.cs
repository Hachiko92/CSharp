using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioForm3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string calculoSueldo()
        {
            string resultado = (Convert.ToDecimal(txtHoras.Text) * Convert.ToDecimal(txtPrecio.Text)).ToString();
            return resultado;
        }
    }
}
