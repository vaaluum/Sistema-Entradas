using System;
using System.Windows.Forms;

namespace SistemdeaEntradas.Forms
{
    public partial class FormVendedor : Form
    {
        public FormVendedor()
        {
            InitializeComponent();
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            FormVentas f = new FormVentas();
            f.ShowDialog();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
