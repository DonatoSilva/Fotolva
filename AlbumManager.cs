using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Fotolva
{
    internal class AlbumManager
    {
        ConnectionDB connectionDB;
        private MySqlConnection conn;

        public AlbumManager() {
            connectionDB = new ConnectionDB();
            this.conn = connectionDB.EstablishConnectionToDB();
            TableVerification();
        }

        public int CreateAlbum(string name, DateTime date, string place, string description)
        {   
            int id = 0;
            using (conn)
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Albums (name, date, place, description) VALUES (@nombre, @date, @place, @description) RETURNING id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", name);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@place", place);
                    cmd.Parameters.AddWithValue("@description", description);
                    id = Convert.ToInt32(cmd.ExecuteNonQuery());
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error al crear el album {name}: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {
                    conn.Close(); 
                }
            }

            return id;
        }

        public DataTable GetAlbums()
        {
            DataTable albumsDataTable = new DataTable();

            using (conn)
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, name, date, place, description FROM Albums";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(albumsDataTable);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al obtener los álbumes: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }

            return albumsDataTable;
        }

        public Dictionary<string, object> GetAlbum(int albumId)
        {
            Dictionary<string, object> albumData = null;

            using (conn)
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, name, date, place, description FROM Albums WHERE id = @albumId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@albumId", albumId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            albumData = new Dictionary<string, object>();
                            albumData["id"] = reader.GetInt32("id");
                            albumData["name"] = reader.GetString("name");
                            albumData["date"] = reader.GetDateTime("date");
                            albumData["place"] = reader.GetString("place");
                            albumData["description"] = reader.GetString("description");
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error al obtener el álbum con ID {albumId}: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }

            return albumData;
        }

        public void UpdateAlbum(int albumId, string name, DateTime date, string place, string description)
        {
            using (conn)
            {
               try
                {
                    conn.Open();
                    string query = "UPDATE Albums SET name = @name, date = @date, place = @place, description = @description WHERE id = @albumId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@albumId", albumId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@place", place);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error al actualizar el álbum con ID {albumId}: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close() ;
                }
            }
        }

        public void DeleteAlbum(int albumId)
        {
            using (conn)
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Albums WHERE id = @albumId;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@albumId", albumId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error al eliminar el álbum con ID {albumId}: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void TableVerification()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS Albums (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(30), date DATE, place VARCHAR(30), description VARCHAR(100));";
                cmd.ExecuteNonQuery();
            } 
            catch (Exception e)
            {
                MessageBox.Show("Error al crear la tabla Albums, mensaje de error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
