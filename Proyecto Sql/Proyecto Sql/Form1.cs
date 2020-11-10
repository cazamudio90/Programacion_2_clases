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

namespace Proyecto_Sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogIn frmlogin = new LogIn();
            
            frmlogin.ShowDialog();

            if (frmlogin.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Usuario invalido");
                LOGIN.miConexion.Close();
                this.Close();
            }
        }
    }
}
