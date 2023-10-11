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
            // Si el formulario no existe, crear una nueva instancia
            if (newAlbum == null)
            {
                newAlbum = new NewAlbum();
                newAlbum.Show();
            }
            // Si el formulario existe, traerlo al frente
            else
            {
                newAlbum.BringToFront();
            }

        }
    }
}
