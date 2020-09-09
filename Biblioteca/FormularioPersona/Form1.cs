using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace FormularioPersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.txtNum1.Text);
            int num2 = int.Parse(this.txtNum1.Text);
            int resultado = num1 + num2;

            this.lblResultado.Text = resultado.ToString();

        }
    }
}
