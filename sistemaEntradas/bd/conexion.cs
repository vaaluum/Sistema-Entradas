using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

namespace sistemaEntradas.bd
{
    internal class conexion
    {
        // cadena para conectarse a MySQL Workbench
        string connectionString = "server=localhost;database=prueba;user=root;password=;";

        // objeto conexión
        MySqlConnection conexionBD;

        // constructor
        public conexion()
        {
            conexionBD = new MySqlConnection(connectionString);
        }

        // abrir conexión
        public MySqlConnection Abrir()
        {
            try
            {
                if (conexionBD.State == System.Data.ConnectionState.Closed)
                {
                    conexionBD.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir: " + ex.Message);
            }

            return conexionBD;
        }
        }