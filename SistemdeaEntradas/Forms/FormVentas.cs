using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using sistemaEntradas.bd;

namespace SistemdeaEntradas.Forms
{
    public partial class FormVentas : Form
    {
        public FormVentas()
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

        private void CboEspectaculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CboEspectaculos.SelectedValue == null) return;

                using (var con = Conexion.ObtenerConexion())
                {
                    string sql = "SELECT id, nombre, precio, capacidad FROM ubicaciones WHERE id_espectaculo=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", CboEspectaculos.SelectedValue);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    CboUbicaciones.DataSource = dt;
                    CboUbicaciones.DisplayMember = "nombre";
                    CboUbicaciones.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ubicaciones: " + ex.Message);
            }
        }

        private void CboUbicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CboUbicaciones.SelectedValue == null) return;

                DataRowView drv = (DataRowView)CboUbicaciones.SelectedItem;
                TxtPrecio.Text = drv["precio"].ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar precio: " + ex.Message);
            }
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    string sql = "INSERT INTO ventas (vendedor, espectaculo, ubicacion, fecha_venta, precio) " +
                                 "VALUES (@v, @e, @u, NOW(), @p)";
                  
                   MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@v", "Vendedor1"); 
                    cmd.Parameters.AddWithValue("@e", CboEspectaculos.Text);
                    cmd.Parameters.AddWithValue("@u", CboUbicaciones.Text);
                    cmd.Parameters.AddWithValue("@p", decimal.Parse(TxtPrecio.Text));
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Entrada vendida con exito!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al vender la entrada: " + ex.Message);
            }
        }
    }
}
