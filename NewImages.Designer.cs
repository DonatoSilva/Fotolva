namespace Fotolva
{
    partial class NewImages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewImages));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleHome = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblNameImage = new System.Windows.Forms.Label();
            this.txtNameImage = new System.Windows.Forms.TextBox();
            this.lblDescriptionImagen = new System.Windows.Forms.Label();
            this.txtDescrptionImage = new System.Windows.Forms.TextBox();
            this.lblListImages = new System.Windows.Forms.Label();
            this.imagesGridView = new System.Windows.Forms.DataGridView();
            this.btnAddListImage = new Fotolva.Custom.ReundedButton();
            this.btnSelectImage = new Fotolva.Custom.ReundedButton();
            this.btnCreateImages = new Fotolva.Custom.ReundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fotolva.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(115, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TitleHome
            // 
            this.TitleHome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TitleHome.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleHome.Location = new System.Drawing.Point(10, 10);
            this.TitleHome.Margin = new System.Windows.Forms.Padding(1);
            this.TitleHome.Name = "TitleHome";
            this.TitleHome.Size = new System.Drawing.Size(111, 39);
            this.TitleHome.TabIndex = 4;
            this.TitleHome.Text = "Fotolva";
            this.TitleHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // title
            // 
            this.title.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.title.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(15, 67);
            this.title.Margin = new System.Windows.Forms.Padding(1);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(437, 39);
            this.title.TabIndex = 12;
            this.title.Text = "Agrega imagenes";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(18, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 1);
            this.panel1.TabIndex = 15;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblNameImage
            // 
            this.lblNameImage.AutoSize = true;
            this.lblNameImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNameImage.Location = new System.Drawing.Point(11, 118);
            this.lblNameImage.Margin = new System.Windows.Forms.Padding(3);
            this.lblNameImage.Name = "lblNameImage";
            this.lblNameImage.Size = new System.Drawing.Size(164, 21);
            this.lblNameImage.TabIndex = 17;
            this.lblNameImage.Text = "Nombre de la imagen:";
            this.lblNameImage.Click += new System.EventHandler(this.LblNameImage_Click);
            // 
            // txtNameImage
            // 
            this.txtNameImage.Location = new System.Drawing.Point(16, 156);
            this.txtNameImage.Name = "txtNameImage";
            this.txtNameImage.Size = new System.Drawing.Size(261, 29);
            this.txtNameImage.TabIndex = 18;
            // 
            // lblDescriptionImagen
            // 
            this.lblDescriptionImagen.AutoSize = true;
            this.lblDescriptionImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDescriptionImagen.Location = new System.Drawing.Point(11, 196);
            this.lblDescriptionImagen.Margin = new System.Windows.Forms.Padding(3);
            this.lblDescriptionImagen.Name = "lblDescriptionImagen";
            this.lblDescriptionImagen.Size = new System.Drawing.Size(187, 21);
            this.lblDescriptionImagen.TabIndex = 19;
            this.lblDescriptionImagen.Text = "Descripción de la imagen:";
            this.lblDescriptionImagen.Click += new System.EventHandler(this.LblDescriptionImagen_Click);
            // 
            // txtDescrptionImage
            // 
            this.txtDescrptionImage.Location = new System.Drawing.Point(15, 229);
            this.txtDescrptionImage.Multiline = true;
            this.txtDescrptionImage.Name = "txtDescrptionImage";
            this.txtDescrptionImage.Size = new System.Drawing.Size(436, 71);
            this.txtDescrptionImage.TabIndex = 20;
            // 
            // lblListImages
            // 
            this.lblListImages.Location = new System.Drawing.Point(15, 349);
            this.lblListImages.Margin = new System.Windows.Forms.Padding(3);
            this.lblListImages.Name = "lblListImages";
            this.lblListImages.Size = new System.Drawing.Size(438, 35);
            this.lblListImages.TabIndex = 22;
            this.lblListImages.Text = "Lista de imagenes seleccionadas:";
            this.lblListImages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imagesGridView
            // 
            this.imagesGridView.AllowUserToOrderColumns = true;
            this.imagesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.imagesGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.imagesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.imagesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.imagesGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.imagesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.imagesGridView.GridColor = System.Drawing.Color.White;
            this.imagesGridView.Location = new System.Drawing.Point(15, 390);
            this.imagesGridView.Name = "imagesGridView";
            this.imagesGridView.ReadOnly = true;
            this.imagesGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imagesGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.imagesGridView.Size = new System.Drawing.Size(437, 230);
            this.imagesGridView.TabIndex = 25;
            this.imagesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ImagesGridView_CellContentClick);
            // 
            // btnAddListImage
            // 
            this.btnAddListImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddListImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(169)))), ((int)(((byte)(211)))));
            this.btnAddListImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(143)))), ((int)(((byte)(118)))));
            this.btnAddListImage.BorderRadius = 15;
            this.btnAddListImage.BorderSize = 0;
            this.btnAddListImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddListImage.FlatAppearance.BorderSize = 0;
            this.btnAddListImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddListImage.ForeColor = System.Drawing.Color.White;
            this.btnAddListImage.Image = global::Fotolva.Properties.Resources.plaza_mas;
            this.btnAddListImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddListImage.Location = new System.Drawing.Point(132, 306);
            this.btnAddListImage.Name = "btnAddListImage";
            this.btnAddListImage.Size = new System.Drawing.Size(199, 39);
            this.btnAddListImage.TabIndex = 24;
            this.btnAddListImage.Text = "Agregar imagen";
            this.btnAddListImage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddListImage.UseVisualStyleBackColor = false;
            this.btnAddListImage.Click += new System.EventHandler(this.BtnAddListImage_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(143)))), ((int)(((byte)(118)))));
            this.btnSelectImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(143)))), ((int)(((byte)(118)))));
            this.btnSelectImage.BorderRadius = 15;
            this.btnSelectImage.BorderSize = 0;
            this.btnSelectImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectImage.FlatAppearance.BorderSize = 0;
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(293, 153);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(159, 34);
            this.btnSelectImage.TabIndex = 16;
            this.btnSelectImage.Text = "Seleccionar";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            this.btnSelectImage.Click += new System.EventHandler(this.BtnSelectImage_Click);
            // 
            // btnCreateImages
            // 
            this.btnCreateImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(169)))), ((int)(((byte)(211)))));
            this.btnCreateImages.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(169)))), ((int)(((byte)(211)))));
            this.btnCreateImages.BorderRadius = 15;
            this.btnCreateImages.BorderSize = 0;
            this.btnCreateImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateImages.FlatAppearance.BorderSize = 0;
            this.btnCreateImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateImages.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateImages.ForeColor = System.Drawing.Color.White;
            this.btnCreateImages.Image = global::Fotolva.Properties.Resources.disco;
            this.btnCreateImages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateImages.Location = new System.Drawing.Point(327, 12);
            this.btnCreateImages.Name = "btnCreateImages";
            this.btnCreateImages.Size = new System.Drawing.Size(125, 39);
            this.btnCreateImages.TabIndex = 6;
            this.btnCreateImages.Text = "Guardar";
            this.btnCreateImages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateImages.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCreateImages.UseVisualStyleBackColor = false;
            this.btnCreateImages.Click += new System.EventHandler(this.BtnCreateImages_Click);
            // 
            // NewImages
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(464, 641);
            this.Controls.Add(this.imagesGridView);
            this.Controls.Add(this.btnAddListImage);
            this.Controls.Add(this.lblListImages);
            this.Controls.Add(this.txtDescrptionImage);
            this.Controls.Add(this.lblDescriptionImagen);
            this.Controls.Add(this.txtNameImage);
            this.Controls.Add(this.lblNameImage);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnCreateImages);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleHome);
            this.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "NewImages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fotolva - Nombre del álbum (Imagenes)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleHome;
        private Custom.ReundedButton btnCreateImages;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Custom.ReundedButton btnSelectImage;
        private System.Windows.Forms.Label lblNameImage;
        private System.Windows.Forms.TextBox txtNameImage;
        private System.Windows.Forms.Label lblDescriptionImagen;
        private System.Windows.Forms.TextBox txtDescrptionImage;
        private System.Windows.Forms.Label lblListImages;
        private Custom.ReundedButton btnAddListImage;
        private System.Windows.Forms.DataGridView imagesGridView;
    }
}