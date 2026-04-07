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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double prod, acre, ven;
            prod = Convert.ToDouble(textBox1.Text);
            acre = Convert.ToDouble(textBox2.Text);

            acre = acre / 100;
            ven = prod + (prod * acre);
            label3.Text = $"Novo valor: {ven:F2}R$";
        }
    }
}
