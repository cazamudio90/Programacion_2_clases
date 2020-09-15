namespace Hospital
{
    partial class FrmABMPaciente
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
            this.btnAceptarPac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptarPac
            // 
            this.btnAceptarPac.Location = new System.Drawing.Point(229, 245);
            this.btnAceptarPac.Name = "btnAceptarPac";
            this.btnAceptarPac.Size = new System.Drawing.Size(132, 44);
            this.btnAceptarPac.TabIndex = 0;
            this.btnAceptarPac.Text = "Aceptar";
            this.btnAceptarPac.UseVisualStyleBackColor = true;
            this.btnAceptarPac.Click += new System.EventHandler(this.btnAceptarPac_Click);
            // 
            // FrmABMPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 331);
            this.Controls.Add(this.btnAceptarPac);
            this.Name = "FrmABMPaciente";
            this.Text = "FrmABMPaciente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarPac;
    }
}