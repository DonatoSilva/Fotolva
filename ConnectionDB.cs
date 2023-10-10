// The library is imported
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Fotolva
{
    internal class ConnectionDB
    {
        // The data for the connection is defined
        private static readonly string server = "localhost";
        private static readonly string port = "3306";
        private static readonly string user = "rot";
        private static readonly string password = "";

        // The data for the db is defined
        private static readonly string nameDB = "DBFotolva";

        private static readonly string connectionString = $"server={server};port={port};user={user};password={password};";

        // the connection returns
        public MySqlConnection EstablishConnection()
        {
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(connectionString);
            } 
            catch (Exception e)
            {
                MessageBox.Show("Error al conectar con la base de datos, mensaje de error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return conn;
        }
    }
}
