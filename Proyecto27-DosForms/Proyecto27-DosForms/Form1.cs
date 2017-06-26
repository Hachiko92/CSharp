using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto27_DosForms
{
    public partial class Form1 : Form
    {
        /* creo un objeto del formulario 2 en el formulario 1 para utilizarlo*/
        Form2 segunda;
        public Form1()
        {
            InitializeComponent();
            segunda = new Form2();
        }

        private void btnIntroducir_Click(object sender, EventArgs e)
        {
            segunda.ShowDialog();
            /* la linea se executa cuando se cierra el form2 */
            txtNombreCompleto.Text = segunda.GetNombreApellido();
        }
    }
}
