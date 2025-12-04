using MySql.Data.MySqlClient;
using sistemaEntradas.bd;
using System;
using System.Data;
using System.Windows.Forms;
namespace sistemaEntradas.forms
{
    public partial class FormEspect : Form
    {
        public FormEspect()
        {
            InitializeComponent();

            CargarEspectaculos();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    string sql = "INSERT INTO espectaculos (nombre, fecha, lugar) VALUES (@n,@f,@l)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@n", TxtNombre.Text);
                    cmd.Parameters.AddWithValue("@f", DtpFecha.Value);
                    cmd.Parameters.AddWithValue("@l", TxtLugar.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Espectáculo guardado!");
                CargarEspectaculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarEspectaculos()
        {
            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    string sql = "SELECT id, nombre, fecha, lugar FROM espectaculos";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DgvEspect.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar espectáculos: " + ex.Message);
            }
        }


    }
}

