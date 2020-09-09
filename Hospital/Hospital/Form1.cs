using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Hospital
{
    public partial class Form1 : Form
    {
        Medico medico_1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int auxDni;
            
            medico_1 = new Medico(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDNI.Text), this.cbEspecialidad.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.txtNombre.Text = "Carlos";
            //this.txtApellido.Text = "Zamudio";
            //this.txtDNI.Text = "35127002";
            //this.cbEspecialidad.Text = "Pediatria";

        }
    }
}
