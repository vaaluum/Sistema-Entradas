using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using sistemaEntradas.bd;
using SistemdeaEntradas.Forms;

namespace sistemaEntradas.forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = Conexion.ObtenerConexion())
                {
                    string sql = "SELECT * FROM usuarios WHERE nombre=@nom AND contraseña=@pass";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nom", TxtUsuario.Text);
                    cmd.Parameters.AddWithValue("@pass", TxtContrasena.Text);

                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string rol = dr["rol"].ToString();
                        if (rol == "Admin")
                        {
                            FormAdmin fa = new FormAdmin();
                            fa.Show();
                            this.Hide();
                        }
                        else
                        {
                            FormVendedor fv = new FormVendedor();
                            fv.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
