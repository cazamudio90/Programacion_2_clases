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
using System.Globalization;

namespace Hospital
{
    public partial class FrmABMMedico : Form
    {
        Medico medico_1;

        public Medico Medico_1
        {
               get { return medico_1; }

               set { medico_1 = value; }
        }

        public FrmABMMedico()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //medico_1 = new Medico("Pepe", "Peposo", 123444,);

            medico_1 = new Medico(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDNI.Text),  (EEspecialidades)this.cbEspecialidad.SelectedItem);
            this.DialogResult = DialogResult.OK;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.txtNombre.Text = "Carlos";
            //this.txtApellido.Text = "Zamudio";
            //this.txtDNI.Text = "35127002";
            //this.cbEspecialidad.Text = "Pediatria";

            this.cbEspecialidad.DataSource = Enum.GetValues(typeof(EEspecialidades));

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            string v_text = ((TextBox)sender).Text;

            v_text  = v_text.Trim();

            int posicion = 1;
            
             for (int i = 0; i < v_text.Length; i++)
             {
                 if (char.Parse(v_text .Substring(i,1)) == ' ')
                 {
                     v_text = string.Concat(v_text.Substring(0, i+1), v_text.Substring( (i + 1), 1).ToUpper() , v_text.Substring(i+2));
                 }
             }
/*
            while (v_text.IndexOf(' ', posicion) > 0)
            {
                //"Ana maria"

                posicion = ((TextBox)sender).Text.IndexOf(' ', posicion);
                v_text = String.Concat(
                    //"Ana "
                    ((TextBox)sender).Text.Substring(0, posicion + 1),
                    //"M"
                    Char.ToUpper(((TextBox)sender).Text[posicion + 1]),
                    //"aria"
                    ((TextBox)sender).Text[posicion + 2] );

                posicion++;

            }*/

            ((TextBox)sender).Text = v_text;
        }
    }
}
