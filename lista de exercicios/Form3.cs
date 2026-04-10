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
    public partial class Form3 : Form
    {
        double not1, not2, not3, res;

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

        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            not1 = Convert.ToDouble(textBox1.Text);
            not2 = Convert.ToDouble(textBox2.Text);
            not3 = Convert.ToDouble(textBox3.Text);

            res = (not1 + not2 + not3) / 3;
            label6.Text = "Resultado: " + res.ToString("F2");
        }
    }
}
