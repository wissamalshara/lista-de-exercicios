using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lista_de_exercicios
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double men, meni, res, menper, meniper;

            men = Convert.ToDouble(textBox1.Text);
            meni = Convert.ToDouble(textBox2.Text);


            res = men + meni;

            menper = (men / res) * 100;
            meniper = (meni / res) * 100;

            label3.Text = "Total de estudantes: " + res;
            label1.Text = $"Porcentagem de meninos: {menper:F2}%";
            label6.Text = $"Porcentagem de meninas: {meniper:F2}%";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
