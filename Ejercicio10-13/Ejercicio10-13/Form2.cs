using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10_13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Text = "Curriculum Vitae Empleado";
        }

        public void mostrarCV(String curriculum)
        {
            txtCV.Text = curriculum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
       
    }
}
