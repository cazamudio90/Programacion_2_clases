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
        List<Medico> listaDeMEdicos;
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
            Paciente pc1 = new Paciente("Juan", "Romero", 12345678,"me duele la cabeza");
            Paciente pc2 = new Paciente("Romina", "Perez", 23456789,"me duele la pierna");
            Paciente pc3 = new Paciente("Elsa", "Rodriguez", 2345678,"me duele la muela");

            //pacientes.Add(pc1);
            //pacientes.Add(pc2);
            //pacientes.Add(pc3);
            if (pacientes + pc1 && pacientes + pc2 && pacientes + pc3)
            {
                this.dgvPacientes.DataSource = pacientes;
            }

            //listaDeMEdicos.Add(new Medico("Juan", "Romero", 12345678, EEspecialidades.Cardiologia));
            
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
