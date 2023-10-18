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
    public partial class ViewAlbum : Form
    {
        private int albumId;
        public ViewAlbum(int id)
        {
            InitializeComponent();

            albumId = id;
        }
    }
}
