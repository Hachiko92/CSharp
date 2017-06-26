using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto28_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "-Selecciona país-";
            comboBox1.Items.Add("Holanda");
            comboBox1.Items.Add("Alemania");
            comboBox1.Items.Add("España");
            comboBox1.Items.Add("Italia");
            comboBox1.Items.Add("Inglaterra");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + " " + comboBox1.Text + " ";
            //label1.Text += dateTimePicker1.Text;

            label1.Text += dateTimePicker1.Value.Date.ToShortDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}