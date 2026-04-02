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
            int m, f, res;
            m = Convert.ToInt32(textBox1.Text);
            f = Convert.ToInt32(textBox2.Text);
            res = m + f;

            label3.Text = "Resultado: " + res;

            label1.Text = "Porcentagem de meninos: " + 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
