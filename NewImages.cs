using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Fotolva
{
    public partial class NewImages : Form
    {
        private int newALbumID; //id of the album to which images are to be added
        private List<SelectedImagenes> hasListImages = new List<SelectedImagenes>(); //has ths list of images
        private List<SelectedImagenes> hasListImagesDelet = new List<SelectedImagenes>();
        private byte[] byteImageSeled = null;//has byte of imagen in progress
        
        //represents the image
        private class SelectedImagenes
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public byte[] BytesImage { get; set; }
            public string Description { get; set; }
        }

        public NewImages()
        { }

        public NewImages(int isNewAlbumId)
        {
            InitializeComponent();
            newALbumID = isNewAlbumId;

            TitleWindows(); //I update the window title
            ConfigureDataGridView();
            GetDataImages(newALbumID);
        }

        private void GetDataImages(int newALbumID)
        {   
            ImageManager imageManager = new ImageManager();
            List<Dictionary<string, object>> images = imageManager.ReadImages(newALbumID);

            foreach (var image in images)
            {
                SelectedImagenes selectedImagenes = new SelectedImagenes
                {   
                    ID = (int)image["id"],
                    Name = image["name"].ToString(),
                    Description = image["description"].ToString(),
                    BytesImage = (byte[])image["dataImage"]
                };

                hasListImages.Add(selectedImagenes);
            }

            ViewlistImagesAlbum();
        }

        private void TitleWindows()
        {
            AlbumManager albumManager = new AlbumManager();
            Dictionary<string, object> album = albumManager.GetAlbum(this.newALbumID);
            string nameAlbum = album["name"].ToString().Trim();
            this.Text = $"Fotolva - {nameAlbum} (Imagenes)";
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;|Todos los archivos|*.*";
                openFileDialog.Title = "Seleccionar una imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;
                        string fileName = Path.GetFileName(filePath);
                        byte[] imageBytes = File.ReadAllBytes(filePath);

                        txtNameImage.Text = txtNameImage.Text.Trim() == "" ? fileName : txtNameImage.Text.Trim();
                        byteImageSeled = imageBytes;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LblNameImage_Click(object sender, EventArgs e)
        {
            txtNameImage.Focus();
        }

        private void LblDescriptionImagen_Click(object sender, EventArgs e)
        {
            txtDescrptionImage.Focus();
        }

        private void BtnAddListImage_Click(object sender, EventArgs e)
        {
            string nameImage = txtNameImage.Text.Trim();
            string descriptionImage = txtDescrptionImage.Text.Trim();

            if (nameImage != "" && descriptionImage != "" && byteImageSeled != null)
            {
                int countLetter = descriptionImage.Length; // var containing the magnitude of description characters

                if (countLetter >= 25 && 100 >= countLetter)
                {
                    SelectedImagenes selectedImagenes = new SelectedImagenes
                    {
                        Name = nameImage,
                        Description = descriptionImage,
                        BytesImage = byteImageSeled
                    };

                    hasListImages.Add(selectedImagenes);
                    ViewlistImagesAlbum();
                    byteImageSeled = null;

                    //se limpian los textBox
                    txtDescrptionImage.Text = "";
                    txtNameImage.Text = "";
                } else
                {
                    MessageBox.Show("La descripcion debe tener entre 25 a 100 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                string messageEmty = nameImage == "" ? "El nombre de la imagen a agregar no puede ser estar vacio" : descriptionImage == "" ? "La imagen a agregar debe tener una descripción" : byteImageSeled == null ? "debe seleccionar una imagen a agregar" : "";

                MessageBox.Show(messageEmty, "¡Espera...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCreateImages_Click(object sender, EventArgs e)
        {
            ImageManager imageManager = new ImageManager();
            if (hasListImages.Any())
            {
                try
                {
                    foreach (var image in hasListImages)
                    {
                        if (image.ID == 0)
                        {
                            imageManager.CreateImage(image.Name, image.Description, image.BytesImage, this.newALbumID);
                        }
                    }

                    MessageBox.Show("Sean guadado las imagenes correctamente al album", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Home home = Application.OpenForms["Home"] as Home;
                    home.BringToFront();
                    home.SetViewListAlbums();
                    this.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Para guargar debes de agregar al menos una imagen", "¡Espera...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (hasListImagesDelet.Any())
            {
                try
                {
                    foreach(var image in hasListImagesDelet)
                    {
                        imageManager.DeleteImage(image.ID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al eliminar las imagenes de la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ViewlistImagesAlbum()
        {
            if (hasListImages.Any())
            {
                // Limpia el DataGridView antes de agregar los elementos
                imagesGridView.Rows.Clear();

                foreach (var selectedImage in hasListImages)
                {
                    // Crea una fila de DataGridView para cada imagen
                    DataGridViewRow row = new DataGridViewRow();

                    // Añade una celda de imagen (BytesImage) a la fila
                    DataGridViewImageCell imageCell = new DataGridViewImageCell();
                    if (selectedImage.BytesImage != null)
                    {
                        using (MemoryStream ms = new MemoryStream(selectedImage.BytesImage))
                        {
                            // Carga la imagen desde el MemoryStream
                            Image originalImage = Image.FromStream(ms);

                            // Redimensiona la imagen al tamaño máximo de 100x100 píxeles
                            Image resizedImage = ResizeImage(originalImage, 100, 100);

                            // Asigna la imagen redimensionada a la celda
                            imageCell.Value = resizedImage;
                        }
                    }
                    row.Cells.Add(imageCell);

                    // Añade una celda de texto (Name) a la fila
                    DataGridViewTextBoxCell textCell = new DataGridViewTextBoxCell();
                    textCell.Value = selectedImage.Name;
                    row.Cells.Add(textCell);

                    // Agrega la fila al DataGridView
                    imagesGridView.Rows.Add(row);
                }
            }
        }

        private void ConfigureDataGridView()
        {
            // Limpia las columnas existentes, si las hay
            imagesGridView.Columns.Clear();

            // Configura una columna de imagen
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Imagen";
            imageColumn.Width = 100;
            imagesGridView.Columns.Add(imageColumn);

            // Configura una columna de texto para el nombre
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Nombre";
            imagesGridView.Columns.Add(nameColumn);

            //configurar columna de eliminar
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Eliminar";
            deleteColumn.Name = "DeleteColumn";
            deleteColumn.Text = "Elimnar";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Width = 100;
            imagesGridView.Columns.Add(deleteColumn);

            // Obtén la última columna (asumiendo que es la columna de texto)
            DataGridViewColumn lastColumn = imagesGridView.Columns[imagesGridView.Columns.Count - 2];

            // Establece FillWeight en 1 para que ocupe todo el espacio disponible
            lastColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastColumn.FillWeight = 1;
            
            /// row
            imagesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //color
            imagesGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            imagesGridView.ForeColor = Color.Black;
            imagesGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;

        }

        public Image ResizeImage(Image image, int maxWidth, int maxHeight)
        {
            int newWidth, newHeight;

            if (image.Width * maxHeight > image.Height * maxWidth)
            {
                newWidth = maxWidth;
                newHeight = (int)(image.Height * ((float)newWidth / image.Width));
            }
            else
            {
                newHeight = maxHeight;
                newWidth = (int)(image.Width * ((float)newHeight / image.Height));
            }

            Image resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics gr = Graphics.FromImage(resizedImage))
            {
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gr.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }

        private void ImagesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == imagesGridView.Columns["deleteColumn"].Index)
                {
                    if (MessageBox.Show("¿Seguro que deseas eliminar esta imagen?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (hasListImages[e.RowIndex].ID > 0)
                        {
                            hasListImagesDelet.Add(hasListImages[e.RowIndex]);
                        }

                        imagesGridView.Rows.RemoveAt(e.RowIndex); // Elimina la fila del datagridview 
                        hasListImages.RemoveAt(e.RowIndex); // lo remueve del arreglo
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }
    }
}
