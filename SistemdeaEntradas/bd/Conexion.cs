using MySql.Data.MySqlClient;

namespace sistemaEntradas.bd
{
    public class Conexion
    {
        public MySqlConnection MiConexion;

        public Conexion()
        {
            string cadena = "server=localhost; database=sistentradas; uid=root; pwd=;";
            MiConexion = new MySqlConnection(cadena);
        }

        public static MySqlConnection ObtenerConexion()
        {
            string cadena = "server=localhost; database=sistentradas; uid=root; pwd=;";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            return con;
        }
    }
}
