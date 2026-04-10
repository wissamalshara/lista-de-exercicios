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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(textBox1.Text);

            label1.Text = num + " vezes 1: " + num * 1;
            label2.Text = num + " vezes 2: " + num * 2;
            label3.Text = num + " vezes 3: " + num * 3;
            label4.Text = num + " vezes 4: " + num * 4;
            label5.Text = num + " vezes 5: " + num * 5;
            label6.Text = num + " vezes 6: " + num * 6;
            label7.Text = num + " vezes 7: " + num * 7;
            label8.Text = num + " vezes 8: " + num * 8;
            label9.Text = num + " vezes 9: " + num * 9;
            label10.Text = num + " vezes 10: " + num * 10;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.FormClosed += (s, args) => this.Show();
            this.Hide();
            menu.Show();
        }
    }
}
