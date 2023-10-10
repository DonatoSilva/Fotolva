using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fotolva
{
    internal class ImageManager
    {
        private ConnectionDB connectionDB;
        private MySqlConnection conn;
        public ImageManager() {
            connectionDB = new ConnectionDB();
            this.conn = connectionDB.EstablishConnectionToDB();
            TableVerification();
        }

        private void TableVerification()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS Images ( id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(30), description VARCHAR(100), dataImage LONGBLOB, albumId INT, FOREIGN KEY (albumId) REFERENCES Albums(id));";
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al crear la tabla Images, mensaje de error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
