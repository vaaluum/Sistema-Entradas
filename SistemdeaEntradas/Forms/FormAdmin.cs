using sistemaEntradas.forms;
using System;
using System.Windows.Forms;

namespace SistemdeaEntradas.Forms
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void BtnEspectaculos_Click(object sender, EventArgs e)
        {
            FormEspect f = new FormEspect();

            f.ShowDialog();
        }

        private void BtnUbicaciones_Click(object sender, EventArgs e)
        {
            FormUbic f = new FormUbic();
            f.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
