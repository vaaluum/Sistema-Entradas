using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using sistemaEntradas.bd; 

namespace SistemdeaEntradas.Forms
{
    public partial class FormUbic : Form
    {
        public FormUbic()
        {
            InitializeComponent();
            CargarEspectaculos(); 
        }

        private void CargarEspectaculos()
        {
          try
            {
             using (var con = Conexion.ObtenerConexion())
                {
                 string sql = "SELECT id, nombre FROM espectaculos";
                 MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 CboEspectaculos.DataSource = dt;
                 CboEspectaculos.DisplayMember = "nombre";
                 CboEspectaculos.ValueMember = "id";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar espectáculos: " + ex.Message);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
            using (var con = Conexion.ObtenerConexion())
            {
                  string sql = "INSERT INTO ubicaciones (id_espectaculo, nombre, precio, capacidad) " +
                               "VALUES (@idEsp, @nombre, @precio, @cap)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idEsp", CboEspectaculos.SelectedValue);
                    cmd.Parameters.AddWithValue("@nombre", TxtNombre.Text);
                    cmd.Parameters.AddWithValue("@precio", decimal.Parse(TxtPrecio.Text));
                    cmd.Parameters.AddWithValue("@cap", int.Parse(TxtCapacidad.Text));
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Ubicación guardada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar ubicación: " + ex.Message);
            }
        }
    }
}
