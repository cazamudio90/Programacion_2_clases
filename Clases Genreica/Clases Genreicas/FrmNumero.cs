using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_Genreicas.Entidades;
using Entidades;

namespace Clases_Genreicas
{
    public partial class FrmNumero : Form
    {
        public FrmNumero()
        {
            InitializeComponent();
        }

        private void FrmNumero_Load(object sender, EventArgs e)
        {
            KwikEMart.CargaClientes();
            KwikEMart.CargarProductos();
            KwikEMart.CargarEmpleados();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
           /* try
            {
                if (!Validaciones<int>.validarValor(int.Parse(this.txtmin.Text), int.Parse(this.txtmax.Text), int.Parse(this.txtValor.Text)))
                {
                    //MessageBox.Show("ok");
                    this.txtValor.Text = "";
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show("El formato no es correcto");
            }*/

            switch (this.cbLista.SelectedItem.ToString())
            {
                case "Productos":
                    llenarDataGridView(KwikEMart.ListaDeProductos);
                    break;
                case "Empleados":
                    llenarDataGridView(KwikEMart.ListaEmleados);
                    break;
                case "Clientes":
                    llenarDataGridView(KwikEMart.ListaDeClientes);
                    break;
            }
        }
        public void llenarDataGridView<T>(List<T> lista_tipo)
        {
            this.dataGridView1.DataSource = lista_tipo;
        }

        private void btnABM_Click(object sender, EventArgs e)
        {
            FrmABM<Producto> frmABM = new FrmABM<Producto>(KwikEMart.ListaDeProductos[0]);

            frmABM.Show();
        }
    }
}
