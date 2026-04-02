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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double m, f, res, porm, porf;
            m = Convert.ToDouble(textBox1.Text);
            f = Convert.ToDouble(textBox2.Text);
            res = m + f;
            porm =  res * (m / 100);
            porf = res * (f / 100);

            label3.Text = "Resultado: " + res;

            label1.Text = "Porcentagem de meninos: " + (porm = Math.Ceiling(porm)) + "%";
            label6.Text = "Porcentagem de meninas: " + (porf = Math.Ceiling(porf)) + "%";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
