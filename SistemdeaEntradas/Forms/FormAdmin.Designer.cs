namespace SistemdeaEntradas.Forms
{
    partial class FormAdmin
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
            this.BtnEspectaculos = new System.Windows.Forms.Button();
            this.BtnUbicaciones = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEspectaculos
            // 
            this.BtnEspectaculos.Location = new System.Drawing.Point(342, 58);
            this.BtnEspectaculos.Name = "BtnEspectaculos";
            this.BtnEspectaculos.Size = new System.Drawing.Size(106, 45);
            this.BtnEspectaculos.TabIndex = 0;
            this.BtnEspectaculos.Text = "Espectaculos";
            this.BtnEspectaculos.UseVisualStyleBackColor = true;
            this.BtnEspectaculos.Click += new System.EventHandler(this.BtnEspectaculos_Click);
            // 
            // BtnUbicaciones
            // 
            this.BtnUbicaciones.Location = new System.Drawing.Point(342, 136);
            this.BtnUbicaciones.Name = "BtnUbicaciones";
            this.BtnUbicaciones.Size = new System.Drawing.Size(106, 45);
            this.BtnUbicaciones.TabIndex = 1;
            this.BtnUbicaciones.Text = "Ubicaciones";
            this.BtnUbicaciones.UseVisualStyleBackColor = true;
            this.BtnUbicaciones.Click += new System.EventHandler(this.BtnUbicaciones_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(332, 241);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(135, 37);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnUbicaciones);
            this.Controls.Add(this.BtnEspectaculos);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEspectaculos;
        private System.Windows.Forms.Button BtnUbicaciones;
        private System.Windows.Forms.Button BtnSalir;
    }
}