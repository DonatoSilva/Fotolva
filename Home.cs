using System.Windows.Forms;

namespace Fotolva
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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
    }
}
