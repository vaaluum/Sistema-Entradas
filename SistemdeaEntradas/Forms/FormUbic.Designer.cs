namespace SistemdeaEntradas.Forms
{
    partial class FormUbic
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.TxtCapacidad = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DgvUbicaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUbicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEspect
            // 
            this.lblEspect.AutoSize = true;
            this.lblEspect.Location = new System.Drawing.Point(299, 44);
            this.lblEspect.Name = "lblEspect";
            this.lblEspect.Size = new System.Drawing.Size(66, 13);
            this.lblEspect.TabIndex = 0;
            this.lblEspect.Text = "Espectaculo";
            // 
            // CboEspectaculos
            // 
            this.CboEspectaculos.FormattingEnabled = true;
            this.CboEspectaculos.Location = new System.Drawing.Point(371, 41);
            this.CboEspectaculos.Name = "CboEspectaculos";
            this.CboEspectaculos.Size = new System.Drawing.Size(121, 21);
            this.CboEspectaculos.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(307, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(374, 85);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(307, 125);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(374, 125);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecio.TabIndex = 5;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(307, 167);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 6;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // TxtCapacidad
            // 
            this.TxtCapacidad.Location = new System.Drawing.Point(374, 167);
            this.TxtCapacidad.Name = "TxtCapacidad";
            this.TxtCapacidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCapacidad.TabIndex = 7;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(350, 224);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(86, 33);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DgvUbicaciones
            // 
            this.DgvUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUbicaciones.Location = new System.Drawing.Point(499, 190);
            this.DgvUbicaciones.Name = "DgvUbicaciones";
            this.DgvUbicaciones.Size = new System.Drawing.Size(240, 150);
            this.DgvUbicaciones.TabIndex = 9;
            // 
            // FormUbic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvUbicaciones);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtCapacidad);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.CboEspectaculos);
            this.Controls.Add(this.lblEspect);
            this.Name = "FormUbic";
            this.Text = "FormUbic";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUbicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEspect;
        private System.Windows.Forms.ComboBox CboEspectaculos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.TextBox TxtCapacidad;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DgvUbicaciones;
    }
}