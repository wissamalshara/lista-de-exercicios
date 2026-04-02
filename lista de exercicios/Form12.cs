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
            double ve, txj, np, vt, vtp;
            
            ve = Convert.ToDouble(textBox1.Text);
            txj = Convert.ToDouble(textBox2.Text);
            np = Convert.ToDouble(textBox3.Text);
            vt = ve * txj / (1 - Math.Pow(1 + txj, -np));
            vtp = vt / (double)np;


            label5.Text = $"Valor total: {vt:F2}";
            label6.Text = $"Valor por parcela: {vtp:F2}";
        }
    }
}
