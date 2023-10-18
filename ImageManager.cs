using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

        public void CreateImage(string name, string description, byte[] imageData, int albumId)
        {
            using (conn)
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Images (name, description, dataImage, albumId) VALUES (@name, @description, @dataImage, @albumId)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@dataImage", imageData);
                    cmd.Parameters.AddWithValue("@albumId", albumId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error al crear la imagen: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public List<Dictionary<string, object>> ReadImages(int albumId)
        {
            List<Dictionary<string, object>> images = new List<Dictionary<string, object>>();

            using (conn)
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, name, description, dataImage, albumId FROM Images WHERE albumId = @albumId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@albumId", albumId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> image = new Dictionary<string, object>();
                            image["id"] = reader.GetInt32("id");
                            image["name"] = reader.GetString("name");
                            image["description"] = reader.GetString("description");
                            image["dataImage"] = (byte[])reader["dataImage"];
                            image["albumId"] = reader.GetInt32("albumId");
                            images.Add(image);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error al obtener las imágenes: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }

            return images;
        }

        public Dictionary<string, object> ReadImage(int imageId)
        {
            Dictionary<string, object> imageData = null;

            using (conn)
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, name, description, dataImage, albumId FROM Images WHERE id = @imageId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@imageId", imageId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            imageData = new Dictionary<string, object>();
                            imageData["id"] = reader.GetInt32("id");
                            imageData["name"] = reader.GetString("name");
                            imageData["description"] = reader.GetString("description");
                            imageData["dataImage"] = reader.GetByte("dataImage");
                            imageData["albumId"] = reader.GetInt32("albumId");
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error al obtener la imagen con ID {imageId}: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }

            return imageData;
        }

        public void DeleteImage(int imageId)
        {
            using (conn)
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Images WHERE id = @imageId;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@imageId", imageId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error al eliminar la imagen con ID {imageId}: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void DeleteImages(int albumId)
        {
            using (conn)
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Images WHERE albumId = @albumId;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@albumId", albumId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error al eliminar las imagenes con albumId {albumId}: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void UpdateImage(int imageId, string name, string description)
        {
            using (conn)
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Images SET name = @name, description = @description WHERE id = @imageId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@imageId", imageId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.ExecuteNonQuery(); 
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error al actualizar la imagen con ID {imageId}: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
