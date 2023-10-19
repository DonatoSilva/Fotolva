using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fotolva
{
    public partial class NewAlbum : Form
    {
        private int albumId = -1;
        private string albumName;
        private string albumPlace;
        private DateTime albumDate;
        private string albumDescription;
        public NewAlbum()
        {
            InitializeComponent();
        }

        public NewAlbum(int albumId)
        {
            InitializeComponent();
            this.albumId = albumId;
            //get album data in state Edit
            HasExistingData();
            //set data
            SetExistingData();
        }

        private void SetExistingData()
        {
            txtNameAlbum.Text = albumName;
            txtDescriptionAlbum.Text = albumDescription;
            txtPlaceAlbum.Text = albumPlace;
            dateTimeAlbum.Value = albumDate;

            this.Text = $"Fotolva - Editar: {albumName}";
        }

        private void HasExistingData()
        {
            AlbumManager albumManager = new AlbumManager();
            Dictionary<string, object> albumData = albumManager.GetAlbum(this.albumId);

            albumName = albumData["name"].ToString();
            albumPlace = albumData["place"].ToString();
            albumDescription = albumData["description"].ToString();
            albumDate = Convert.ToDateTime(albumData["date"]);
        }

        private void BtnCreateAlbum_Click(object sender, EventArgs e)
        {
            string name = txtNameAlbum.Text.Trim();
            string place = txtPlaceAlbum.Text.Trim();
            string description = txtDescriptionAlbum.Text.Trim();
            DateTime dateTime = dateTimeAlbum.Value;

            //It is verified that no field is empty
            if (name != "" && place != "" && description != "")
            {   
                //Create new Album in db
                AlbumManager albumManager = new AlbumManager();
                try
                {
                    if (albumId != -1)
                    {
                        if (name != albumName || place != albumPlace || description != albumDescription || dateTime != albumDate)
                        {
                            albumManager.UpdateAlbum(albumId, name, dateTime, place, description);
                            MessageBox.Show($"Se actualizo el album {albumName}", "Excelente", MessageBoxButtons.OK);
                        } 

                        NewImages newImages = new NewImages(albumId);
                        newImages.Show();
                        this.Close();
                    } else
                    {
                        int newAlbumID = albumManager.CreateAlbum(name, dateTime, place, description);

                        // Check if newAlbumID has value
                        if (newAlbumID != -1)
                        {
                            // open newImages
                            NewImages newImages = new NewImages(newAlbumID);
                            newImages.Show();
                            this.Close();
                        }
                    }
                } 
                catch (Exception ex)
                {
                    MessageBox.Show($"Error, algo a salido mal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // If this empty message is displayed to user
            {
                string messageFormEmpty = name == "" ? "El nombre" : place == "" ? "El lugar" : description == "" ? "La descripción" : "";

                MessageBox.Show($"{messageFormEmpty} del álbum no puede estar vacio", "¡Espera!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void LblPlaceAlbum_Click(object sender, EventArgs e)
        {
            txtPlaceAlbum.Focus();
        }

        private void LblDescrptionAlbum_Click(object sender, EventArgs e)
        {
            txtDescriptionAlbum.Focus();
        }

        private void LblDateAlbum_Click(object sender, EventArgs e)
        {
            dateTimeAlbum.Focus();
        }

        private void LblNameAlbum_Click(object sender, EventArgs e)
        {
            txtNameAlbum.Focus();
        }

        private void TxtNameAlbum_TextChanged(object sender, EventArgs e)
        {
            if (txtNameAlbum.Text.Trim() != "")
            {
                titleNewAlbum.Text = txtNameAlbum.Text.Trim();
            } else
            {
                titleNewAlbum.Text = "Nuevo álbum";
            }
        }
    }
}
