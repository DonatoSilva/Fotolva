namespace Fotolva
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.TitleHome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewAlbum = new Fotolva.Custom.ReundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleHome
            // 
            this.TitleHome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TitleHome.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleHome.Location = new System.Drawing.Point(10, 10);
            this.TitleHome.Margin = new System.Windows.Forms.Padding(1);
            this.TitleHome.Name = "TitleHome";
            this.TitleHome.Size = new System.Drawing.Size(117, 39);
            this.TitleHome.TabIndex = 0;
            this.TitleHome.Text = "Fotolva";
            this.TitleHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fotolva.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(120, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnNewAlbum
            // 
            this.btnNewAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.btnNewAlbum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.btnNewAlbum.BorderRadius = 15;
            this.btnNewAlbum.BorderSize = 0;
            this.btnNewAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAlbum.FlatAppearance.BorderSize = 0;
            this.btnNewAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAlbum.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAlbum.ForeColor = System.Drawing.Color.White;
            this.btnNewAlbum.Image = global::Fotolva.Properties.Resources.plaza_mas;
            this.btnNewAlbum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewAlbum.Location = new System.Drawing.Point(363, 10);
            this.btnNewAlbum.Name = "btnNewAlbum";
            this.btnNewAlbum.Size = new System.Drawing.Size(107, 39);
            this.btnNewAlbum.TabIndex = 3;
            this.btnNewAlbum.Text = "Nuevo";
            this.btnNewAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNewAlbum.UseVisualStyleBackColor = false;
            this.btnNewAlbum.Click += new System.EventHandler(this.BtnNewAlbum_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Álbumes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpAlbums
            // 
            this.tlpAlbums.AutoScroll = true;
            this.tlpAlbums.Location = new System.Drawing.Point(14, 106);
            this.tlpAlbums.Name = "tlpAlbums";
            this.tlpAlbums.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlpAlbums.Size = new System.Drawing.Size(455, 515);
            this.tlpAlbums.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(15, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 1);
            this.panel1.TabIndex = 15;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlpAlbums);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewAlbum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleHome);
            this.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fotolva - Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Custom.ReundedButton btnNewAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel tlpAlbums;
        private System.Windows.Forms.Panel panel1;
    }
}

