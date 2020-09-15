using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FrmABMPaciente : Form
    {

        private Paciente paciente;

        public Paciente MiPaciente
        {
            get { return paciente; }
            set { paciente = value; }
        }   

        public FrmABMPaciente()
        {
            InitializeComponent();
        }

        private void btnAceptarPac_Click(object sender, EventArgs e)
        {
            this.paciente = new Paciente("Juan", "Perez", 12345678, "Me duele la cabeza");

            this.DialogResult = DialogResult.OK;
        }

    }
}
