using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btDobrar_Click(object sender, EventArgs e)
        {
            float valor = float.Parse(tbValor.Text);
            valor *= 2;
            lbResultado.Text = valor.ToString();
        }
    }
}
