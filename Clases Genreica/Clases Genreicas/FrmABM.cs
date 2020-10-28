using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases_Genreicas
{
    public partial class FrmABM<T> : Form where T : class
    {
        public FrmABM( T objectoACrear)
        {
            InitializeComponent();

            int r = 20;

            foreach (PropertyInfo item in typeof(T).GetProperties() )
            {
                Label labelDinamico = new Label();
                TextBox textDinamico = new TextBox();
                labelDinamico.Text = item.Name;
                textDinamico.Text = item.GetValue(objectoACrear).ToString();

                labelDinamico.Name = "lbl" + item.Name;
                textDinamico.Name = "txt" + item.Name;

                labelDinamico.Location = new Point(20, r);
                textDinamico.Location = new Point(220, r);

                r += 60;

                this.Controls.Add(labelDinamico);
                this.Controls.Add(textDinamico);
            }
        }
    }
}
