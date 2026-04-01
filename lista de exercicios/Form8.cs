using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_de_exercicios
{
    public partial class Form8 : Form
    {
        double n1, n2, n3;

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox4.Text);
            n2 = Convert.ToDouble(textBox5.Text);
            n3 = Convert.ToDouble(textBox6.Text);

            label11.Text = "Média 2: " + (n1 + n2 + n3) / 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox7.Text);
            n2 = Convert.ToDouble(textBox8.Text);
            n3 = Convert.ToDouble(textBox9.Text);

            label12.Text = "Média 3: " + (n1 + n2 + n3) / 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox10.Text);
            n2 = Convert.ToDouble(textBox11.Text);
            n3 = Convert.ToDouble(textBox12.Text);

            label13.Text = "Média 4: " + (n1 + n2 + n3) / 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox13.Text);
            n2 = Convert.ToDouble(textBox14.Text);
            n3 = Convert.ToDouble(textBox15.Text);

            label14.Text = "Média 5: " + (n1 + n2 + n3) / 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            n3 = Convert.ToInt32(textBox3.Text);

            label10.Text = "Média 1: " + (n1 + n2 + n3) / 3;
        }
    }
}
