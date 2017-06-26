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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void carga_nombre(string nombre, string apellido)
        {
            txtNombreCompleto.Text = nombre + " " + apellido;
        }

        public void carga_dias(int edad)
        {
            int dias = edad * 365;
            txtDias.Text = dias.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = "";
            if (checkBox1.Checked)
            {
                Text = Text + ("Inglés");
                //Text = Text + checkBox1.Name;
            }
            if (checkBox2.Checked)
            {
                Text = Text + ("Aléman");
            }
            if (checkBox3.Checked)
            {
                Text = Text + ("Francés");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Width = 640;
                Height = 480;
            }
            else
            {
                if(radioButton4.Checked)
                {
                    Width = 800;
                    Height = 600;
                }
                else
                {
                    Width = 1024;
                    Height = 768;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Width = 640;
            Height = 480;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Width = 800;
            Height = 600;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Width = 1024;
            Height = 768;
        }
        
    }
}
