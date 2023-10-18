using Fotolva.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Fotolva
{
    public partial class Home : Form
    {
        private DataTable albumsDataTable;
        public Home()
        {
            InitializeComponent();
            SetViewListAlbums();
        }

        
        private void BtnNewAlbum_Click(object sender, System.EventArgs e)
        {
            // Buscar el formulario dentro de la colección Application.OpenForms
            NewAlbum newAlbum = Application.OpenForms["NewAlbum"] as NewAlbum;
            NewImages newImages = Application.OpenForms["NewImages"] as NewImages;
            // Si el formulario no existe, crear una nueva instancia
            if (newAlbum == null)
            {
                newAlbum = new NewAlbum();
                newAlbum.Show();
            } else if (newImages != null)
            {
               newImages.BringToFront();
               MessageBox.Show("Ya existe la creación de un álbum en proceso, termina o cancela el proceso para iniciar con la creacion de un nuevo album", "¡Espera...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // Si el formulario existe, traerlo al frente
            {
                newAlbum.BringToFront();
            }

        }

        private void GetAlbums()
        {
            if (albumsDataTable != null)
            {
                albumsDataTable.Clear();
            }

            if (tlpAlbums.Controls.Count > 0)
            {
                tlpAlbums.Controls.Clear();
            }

            AlbumManager albumManager = new AlbumManager();
            
            try
            {
                albumsDataTable = albumManager.GetAlbums(); 
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetViewListAlbums()
        {   //get the list the album
            GetAlbums();
            // Configura tu FlowLayoutPanel para tener dos columnas y sin espaciado entre controles.
            tlpAlbums.FlowDirection = FlowDirection.LeftToRight; // Para dos columnas.

            foreach (DataRow row in albumsDataTable.Rows)
            {
                List<Dictionary<string, object>> images = new List<Dictionary<string, object>>();
                ImageManager imageManager = new ImageManager();
                images = imageManager.ReadImages(Convert.ToInt32(row["id"]));

                // Crea un panel para cada "fila" de datos.
                Panel panel = new Panel();
                // Establecer AutoSize y AutoSizeMode para el panel.
                panel.AutoSize = false;
                panel.Width = (tlpAlbums.Width - 30) / 2;
                panel.Height = 180;
                panel.BackColor = Color.White;
                panel.ForeColor = Color.Black;
                panel.Padding = new Padding(3);
                panel.Margin = new Padding(3);

                // Crea una PictureBox para mostrar la imagen del álbum.
                PictureBox pictureBox = new PictureBox();
                if (images.Count > 0)
                {
                    byte[] imageData = (byte[])images[0]["dataImage"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Ajusta el tamaño de la imagen al PictureBox.
                    pictureBox.BackColor = Color.Black;
                }
                pictureBox.Dock = DockStyle.Top;
                pictureBox.Size = new Size(panel.ClientSize.Width, panel.ClientSize.Height / 2);

                // Crea una etiqueta para mostrar el nombre del álbum.
                Label label = new Label();
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font(btnNewAlbum.Font, FontStyle.Bold);
                label.Width = panel.Width;
                label.Text = row["name"].ToString(); // Reemplaza 'name' con el nombre de la columna en el DataTable.
                label.Dock = DockStyle.Top;

                // Crea dos botones.
                ReundedButton btnViewAlbum = new ReundedButton();
                btnViewAlbum.Text = "Ver";
                btnViewAlbum.Font = new Font(btnNewAlbum.Font, FontStyle.Regular);
                btnViewAlbum.AutoSize = true;
                btnViewAlbum.Dock = DockStyle.Top;
                btnViewAlbum.BackColor = Color.FromArgb(150, 169, 211);
                btnViewAlbum.BorderRadius = 0;
                btnViewAlbum.Click += (sender, e) =>
                {
                    ViewAlbum(Convert.ToInt32(row["id"]));
                };

                ReundedButton btnDeleteAlbum = new ReundedButton();
                btnDeleteAlbum.Text = "Eliminar";
                btnDeleteAlbum.AutoSize = true;
                btnDeleteAlbum.Dock = DockStyle.Top;
                btnDeleteAlbum.BackColor = Color.FromArgb(169,143,118);
                btnDeleteAlbum.BorderRadius = 0;
                btnDeleteAlbum.Click += (sender, e) => 
                {
                    DeleteAlbum(Convert.ToInt32(row["id"]), row["name"].ToString());
                };

                // Agrega los controles al panel sin espaciado entre controles.
                panel.Controls.Add(btnDeleteAlbum);
                panel.Controls.Add(btnViewAlbum);
                panel.Controls.Add(label);
                panel.Controls.Add(pictureBox);

                // Agrega el panel al FlowLayoutPanel.
                tlpAlbums.Controls.Add(panel);
                tlpAlbums.AutoScroll = true;
            }
        }

        private void DeleteAlbum(int id, string name)
        {
            if (MessageBox.Show($"Seguro que quiere elimnar el album: {name}", "Comfirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    AlbumManager albumManager = new AlbumManager();
                    ImageManager imageManager = new ImageManager();

                    albumManager.DeleteAlbum(id);
                    imageManager.DeleteImages(id);
                } catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el álbum y sus respectivas imagenes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } finally
                {
                    SetViewListAlbums();
                }
            }
        }

        private void ViewAlbum(int id)
        {
            ViewAlbum viewAlbum = new ViewAlbum(id);
            viewAlbum.Show();
        }
    }
}
