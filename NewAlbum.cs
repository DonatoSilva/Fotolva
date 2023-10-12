using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fotolva
{
    public partial class NewAlbum : Form
    {
        public NewAlbum()
        {
            InitializeComponent();
        }

        private void BtnCreateAlbum_Click(object sender, EventArgs e)
        {
            string name = txtNameAlbum.Text.Trim();
            string place = txtPlaceAlbum.Text.Trim();
            string description = txtDescriptionAlbum.Text.Trim();
            DateTime dateTime = dateTimeAlbum.Value;

            if (name != "" && place != "" && description != "")
            {
                
            } else
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
