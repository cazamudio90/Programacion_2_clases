using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatUI
{
    public partial class FrmPrincipal : Form
    {
        private Usuario userLog;
        Thread t;
        public FrmPrincipal(Usuario user)
        {
            InitializeComponent();
            userLog = user;
            lblBienvenido.Text = $"Bienvenido {user.Nombre} {user.Apellido}"; 
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.cbPersonas.DataSource = DB.TraerPersonas();

            this.cbPersonas.DisplayMember = "apellido";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DB.InsertaMensje(this.userLog, (Persona)cbPersonas.SelectedItem, this.rtxMensaje.Text );
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

            if (t is null)
            {
                this.t = new Thread(new ParameterizedThreadStart(RefrescarMensajes));
                t.Start(5000);
            }
            else if(t.IsAlive)
            {
                t.Abort();
                t = new Thread(new ParameterizedThreadStart(RefrescarMensajes));
                t.Start(3000);
            }
        }

        public void RefrescarMensajes(object segundos)
        {
            List<Mensaje> mensajes = DB.TraerMensajes(userLog, DB.TraerPersonas());

            if (this.txtMensajes.InvokeRequired)
            {
                this.txtMensajes.BeginInvoke((MethodInvoker)delegate()
                {

                    this.txtMensajes.Text = "";

                    foreach (Mensaje item in mensajes)
                    {

                        this.txtMensajes.Text += item.persona.Nombre + ": " + item.TextoMensaje + "\n";
                    }

                    Thread.Sleep((int)segundos);
                    RefrescarMensajes(segundos);
                });
            }

        }


    }
}
