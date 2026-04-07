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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ve, np, txp, vpt, vt;

            ve = Convert.ToDouble(textBox3.Text);
            np = Convert.ToDouble(textBox2.Text);
            txp = Convert.ToDouble(textBox1.Text);

            txp = txp / 100;

            vt = ve + (ve * txp);
            vpt = vt / np;


            label5.Text = $"Valor total: {vt:F2}R$";
            label6.Text = $"Valor por parcela: {vtp:F2}R$";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
