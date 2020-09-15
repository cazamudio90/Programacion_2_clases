using Entidades;
using System;
using System.Collections;
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
    public partial class FrmPrincipal : Form
    {
        Medico[] medicos;
        //Paciente[] pacientes;
        //object[] pacientes;
        List<Paciente> pacientes;
        ArrayList enfermedades;


        public FrmPrincipal()
        {
            InitializeComponent();
            medicos = new Medico[25];
            //pacientes = new Paciente[25];
            pacientes = new List<Paciente>();
            enfermedades = new ArrayList(5);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMMedico frmABMMedico = new FrmABMMedico();
            if (frmABMMedico.ShowDialog() == DialogResult.OK)
            {
               if (medicos + frmABMMedico.Medico_1)
                {
                    MessageBox.Show("Se agrego un Medico");
                }
            }
            
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;    
            }
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMPaciente frmABMPaciente = new FrmABMPaciente();

            if (frmABMPaciente.ShowDialog() == DialogResult.OK)
            {
                if (pacientes + frmABMPaciente.MiPaciente)
                {
                    MessageBox.Show("Se agrego un Paciente");
                }
            }
        }
    }
}
