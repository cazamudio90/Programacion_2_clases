using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_Genreicas.Entidades;

namespace Clases_Genreicas
{
    public partial class FrmNumeroFloat : Form
    {
        public FrmNumeroFloat()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validaciones<float>.validarValor(float.Parse(this.txtmin.Text), float.Parse(this.txtmax.Text), float.Parse(this.txtValor.Text)))
                {
                    //MessageBox.Show("ok");
                    this.txtValor.Text = "";
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El formato no es correcto");
            }
        }
    }
}
