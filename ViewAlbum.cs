using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fotolva
{
    public partial class ViewAlbum : Form
    {
        private readonly int albumId;
        private readonly string albumName;
        private Dictionary<string, object> albumData = new Dictionary<string, object>();
        private List<Dictionary<string, object>> imagesData = new List<Dictionary<string, object>>();
        public ViewAlbum(int idAlbum, string nameAlbum)
        {
            InitializeComponent();

            albumId = idAlbum;
            albumName = nameAlbum;

            //update title the form
            this.Text = $"Fotolva - {this.albumName}";
            GetAlbumData(); //the load album data
            GetImageData(); //the load album data
            ConfigColumnDataGridView();
            AddRowDataGridView(imagesData);
            ViewAlbumData();
        }

        private void ViewAlbumData()
        {
            lblNameAlbum.Text = this.albumName;
            lblPlaceAlbum.Text = albumData["place"].ToString();
            lblDateAlbum.Text = albumData["date"].ToString();
            lblDescriptionAlbum.Text = albumData["description"].ToString();

            if (imagesData.Any())
            {
                lblNameImage.Text = lblNameImage.Text == "..." ? imagesData[0]["name"].ToString() : lblNameImage.Text;
                lblDescriptionImage.Text = lblDescriptionImage.Text == "..." ? imagesData[0]["description"].ToString() : lblDescriptionImage.Text;
                byte[] databy = (byte[])imagesData[0]["dataImage"];
                using (var stream = new MemoryStream(databy))
                {
                    pImage.SizeMode = PictureBoxSizeMode.Zoom;
                    pImage.Image = Image.FromStream(stream);
                }
            }
        }

        private void BtnDeleteAlbum_Click(object sender, EventArgs e)
        {
            AlbumManager albumManager = new AlbumManager();
            ImageManager imageManager = new ImageManager();
            Home home = Application.OpenForms["Home"] as Home;
            try
            {
                DialogResult result = MessageBox.Show($"Seguro que quieriere eliminar el álbum {this.albumName}", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Question);
            
                if (result == DialogResult.OK)
                {   
                    imageManager.DeleteImages(this.albumId);
                    albumManager.DeleteAlbum(this.albumId);
                    home.SetViewListAlbums();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al eliminar el album y sus imagenes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Close();
            }
        }

        private void GetAlbumData()
        {
            AlbumManager albumManager = new AlbumManager();

            try
            {
                albumData.Clear();
                albumData = albumManager.GetAlbum(this.albumId);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al obtener la información del album: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetImageData()
        {
            ImageManager imageManager = new ImageManager();

            try
            {
                imagesData.Clear();
                imagesData = imageManager.ReadImages(this.albumId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la data de la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigColumnDataGridView()
        {
            // Limpia las columnas existentes en el DataGridView
            dataGridView1.Columns.Clear();

            // Crea una nueva columna de imágenes
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Imagen";
            imageColumn.Name = "ImageColumn"; // Puedes asignar un nombre a la columna si es necesario
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Esta configuración permite que la columna ocupe el 100%
            dataGridView1.Columns.Add(imageColumn);

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void AddRowDataGridView(List<Dictionary<string, object>> imagesData)
        {   NewImages newImages = new NewImages();

            foreach (var imageData in imagesData)
            {
                if (imageData.ContainsKey("dataImage") && imageData["dataImage"] is byte[])
                {
                    byte[] imageBytes = (byte[])imageData["dataImage"];

                    if (imageBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image originalImage = Image.FromStream(ms);

                            Image resizedImage = newImages.ResizeImage(originalImage, 100, 100);
                            // Crea una fila para el DataGridView
                            DataGridViewRow fila = new DataGridViewRow();

                            DataGridViewImageCell celdaImagen = new DataGridViewImageCell();
                            celdaImagen.Value = resizedImage;
                            fila.Cells.Add(celdaImagen);
                            dataGridView1.Rows.Add(fila);
                        }
                    }
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "ImageColumn" && e.RowIndex < dataGridView1.Rows.Count)
            {
                try
                {
                    byte[] databy = (byte[])imagesData[e.RowIndex]["dataImage"];
                    using (var stream = new MemoryStream(databy))
                    {
                        pImage.Image = Image.FromStream(stream);
                    }
                    lblDescriptionImage.Text = imagesData[e.RowIndex]["description"].ToString();
                    lblNameImage.Text = imagesData[e.RowIndex]["name"].ToString();
                } 
                catch {
                    byte[] databy = (byte[])imagesData[0]["dataImage"];
                    using (var stream = new MemoryStream(databy))
                    {
                        pImage.Image = Image.FromStream(stream);
                    }
                    lblDescriptionImage.Text = imagesData[0]["description"].ToString();
                    lblNameImage.Text = imagesData[0]["name"].ToString();
                }
            }
        }

        private void BtnEditAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                NewAlbum newAlbum = new NewAlbum(this.albumId);
                newAlbum.Show();
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
