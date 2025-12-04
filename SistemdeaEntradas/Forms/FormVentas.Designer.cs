namespace SistemdeaEntradas.Forms
{
    partial class FormVentas
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
            this.lblEspect = new System.Windows.Forms.Label();
            this.CboEspectaculos = new System.Windows.Forms.ComboBox();
            this.lblUbic = new System.Windows.Forms.Label();
            this.CboUbicaciones = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnVender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEspect
            // 
            this.lblEspect.AutoSize = true;
            this.lblEspect.Location = new System.Drawing.Point(277, 36);
            this.lblEspect.Name = "lblEspect";
            this.lblEspect.Size = new System.Drawing.Size(71, 13);
            this.lblEspect.TabIndex = 0;
            this.lblEspect.Text = "Espectaculos";
            // 
            // CboEspectaculos
            // 
            this.CboEspectaculos.FormattingEnabled = true;
            this.CboEspectaculos.Location = new System.Drawing.Point(354, 33);
            this.CboEspectaculos.Name = "CboEspectaculos";
            this.CboEspectaculos.Size = new System.Drawing.Size(121, 21);
            this.CboEspectaculos.TabIndex = 1;
            this.CboEspectaculos.SelectedIndexChanged += new System.EventHandler(this.cboEspectaculos_SelectedIndexChanged);
            // 
            // lblUbic
            // 
            this.lblUbic.AutoSize = true;
            this.lblUbic.Location = new System.Drawing.Point(293, 85);
            this.lblUbic.Name = "lblUbic";
            this.lblUbic.Size = new System.Drawing.Size(55, 13);
            this.lblUbic.TabIndex = 2;
            this.lblUbic.Text = "Ubicacion";
            // 
            // CboUbicaciones
            // 
            this.CboUbicaciones.FormattingEnabled = true;
            this.CboUbicaciones.Location = new System.Drawing.Point(354, 85);
            this.CboUbicaciones.Name = "CboUbicaciones";
            this.CboUbicaciones.Size = new System.Drawing.Size(121, 21);
            this.CboUbicaciones.TabIndex = 3;
            this.CboUbicaciones.SelectedIndexChanged += new System.EventHandler(this.CboUbicaciones_SelectedIndexChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(311, 143);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(354, 140);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecio.TabIndex = 5;
            // 
            // BtnVender
            // 
            this.BtnVender.Location = new System.Drawing.Point(323, 214);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(91, 39);
            this.BtnVender.TabIndex = 6;
            this.BtnVender.Text = "Vender";
            this.BtnVender.UseVisualStyleBackColor = true;
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVender);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.CboUbicaciones);
            this.Controls.Add(this.lblUbic);
            this.Controls.Add(this.CboEspectaculos);
            this.Controls.Add(this.lblEspect);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEspect;
        private System.Windows.Forms.ComboBox CboEspectaculos;
        private System.Windows.Forms.Label lblUbic;
        private System.Windows.Forms.ComboBox CboUbicaciones;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Button BtnVender;
    }
}