namespace Clases_Genreicas
{
    partial class FrmNumero
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblmin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbLista = new System.Windows.Forms.ComboBox();
            this.btnABM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Location = new System.Drawing.Point(51, 18);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(67, 13);
            this.lblmin.TabIndex = 0;
            this.lblmin.Text = "Valor Minimo";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(213, 18);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(70, 13);
            this.lblMax.TabIndex = 1;
            this.lblMax.Text = "Valor Maximo";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(394, 18);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor";
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(60, 55);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(69, 20);
            this.txtmin.TabIndex = 3;
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(223, 55);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(69, 20);
            this.txtmax.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(388, 55);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(69, 20);
            this.txtValor.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(439, 308);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(144, 41);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(349, 183);
            this.dataGridView1.TabIndex = 7;
            // 
            // cbLista
            // 
            this.cbLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbLista.FormattingEnabled = true;
            this.cbLista.Items.AddRange(new object[] {
            "Productos",
            "Clientes",
            "Empleados"});
            this.cbLista.Location = new System.Drawing.Point(448, 125);
            this.cbLista.Name = "cbLista";
            this.cbLista.Size = new System.Drawing.Size(135, 21);
            this.cbLista.TabIndex = 8;
            // 
            // btnABM
            // 
            this.btnABM.Location = new System.Drawing.Point(48, 329);
            this.btnABM.Name = "btnABM";
            this.btnABM.Size = new System.Drawing.Size(154, 20);
            this.btnABM.TabIndex = 9;
            this.btnABM.Text = "ABM";
            this.btnABM.UseVisualStyleBackColor = true;
            this.btnABM.Click += new System.EventHandler(this.btnABM_Click);
            // 
            // FrmNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 361);
            this.Controls.Add(this.btnABM);
            this.Controls.Add(this.cbLista);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblmin);
            this.Name = "FrmNumero";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmNumero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbLista;
        private System.Windows.Forms.Button btnABM;
    }
}

