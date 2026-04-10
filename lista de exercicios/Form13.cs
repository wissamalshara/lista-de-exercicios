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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ven, venval, sf, res;
            string nome;
            nome = Convert.ToString(textBox1.Text);
            ven = Convert.ToDouble(textBox3.Text);
            sf = Convert.ToDouble(textBox2.Text);

            venval = ven / 5;
            res = sf + venval;
            label5.Text = nome + $" seu salário total é: {res:F2}R$";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
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
