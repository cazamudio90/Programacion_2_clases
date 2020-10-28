namespace Clases_Genreicas
{
    partial class FrmNumeroFloat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(250, 276);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(342, 41);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(415, 145);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(85, 20);
            this.txtValor.TabIndex = 12;
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(250, 145);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(85, 20);
            this.txtmax.TabIndex = 11;
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(87, 145);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(85, 20);
            this.txtmin.TabIndex = 10;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(437, 108);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(256, 108);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(70, 13);
            this.lblMax.TabIndex = 8;
            this.lblMax.Text = "Valor Maximo";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Location = new System.Drawing.Point(94, 108);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(67, 13);
            this.lblmin.TabIndex = 7;
            this.lblmin.Text = "Valor Minimo";
            // 
            // FrmNumeroFloat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 379);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblmin);
            this.Name = "FrmNumeroFloat";
            this.Text = "FrmNumeroFloat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblmin;
    }
}