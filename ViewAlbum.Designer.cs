namespace Fotolva
{
    partial class ViewAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAlbum));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDescriptionImage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNameImage = new System.Windows.Forms.Label();
            this.btnDeleteAlbum = new Fotolva.Custom.ReundedButton();
            this.TitleHome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditAlbum = new Fotolva.Custom.ReundedButton();
            this.pImage = new System.Windows.Forms.PictureBox();
            this.lblNameAlbum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPlaceAlbum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescriptionAlbum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(213, 341);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblDescriptionImage);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblNameImage);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(213, 429);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 69);
            this.panel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(209, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "Descripción:";
            // 
            // lblDescriptionImage
            // 
            this.lblDescriptionImage.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionImage.Location = new System.Drawing.Point(209, 37);
            this.lblDescriptionImage.Name = "lblDescriptionImage";
            this.lblDescriptionImage.Size = new System.Drawing.Size(348, 22);
            this.lblDescriptionImage.TabIndex = 20;
            this.lblDescriptionImage.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre:";
            // 
            // lblNameImage
            // 
            this.lblNameImage.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameImage.Location = new System.Drawing.Point(6, 37);
            this.lblNameImage.Name = "lblNameImage";
            this.lblNameImage.Size = new System.Drawing.Size(197, 22);
            this.lblNameImage.TabIndex = 16;
            this.lblNameImage.Text = "...";
            // 
            // btnDeleteAlbum
            // 
            this.btnDeleteAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(143)))), ((int)(((byte)(118)))));
            this.btnDeleteAlbum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(143)))), ((int)(((byte)(118)))));
            this.btnDeleteAlbum.BorderRadius = 15;
            this.btnDeleteAlbum.BorderSize = 0;
            this.btnDeleteAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAlbum.FlatAppearance.BorderSize = 0;
            this.btnDeleteAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAlbum.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAlbum.Image = global::Fotolva.Properties.Resources.eliminar;
            this.btnDeleteAlbum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAlbum.Location = new System.Drawing.Point(404, 12);
            this.btnDeleteAlbum.Name = "btnDeleteAlbum";
            this.btnDeleteAlbum.Size = new System.Drawing.Size(184, 39);
            this.btnDeleteAlbum.TabIndex = 4;
            this.btnDeleteAlbum.Text = "Eliminar Album";
            this.btnDeleteAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteAlbum.UseVisualStyleBackColor = false;
            // 
            // TitleHome
            // 
            this.TitleHome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TitleHome.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleHome.Location = new System.Drawing.Point(9, 12);
            this.TitleHome.Margin = new System.Windows.Forms.Padding(1);
            this.TitleHome.Name = "TitleHome";
            this.TitleHome.Size = new System.Drawing.Size(111, 39);
            this.TitleHome.TabIndex = 6;
            this.TitleHome.Text = "Fotolva";
            this.TitleHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fotolva.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(114, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditAlbum
            // 
            this.btnEditAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(169)))), ((int)(((byte)(211)))));
            this.btnEditAlbum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(143)))), ((int)(((byte)(118)))));
            this.btnEditAlbum.BorderRadius = 15;
            this.btnEditAlbum.BorderSize = 0;
            this.btnEditAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAlbum.FlatAppearance.BorderSize = 0;
            this.btnEditAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAlbum.ForeColor = System.Drawing.Color.White;
            this.btnEditAlbum.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAlbum.Image")));
            this.btnEditAlbum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAlbum.Location = new System.Drawing.Point(594, 12);
            this.btnEditAlbum.Name = "btnEditAlbum";
            this.btnEditAlbum.Size = new System.Drawing.Size(176, 39);
            this.btnEditAlbum.TabIndex = 3;
            this.btnEditAlbum.Text = "Editar Album";
            this.btnEditAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditAlbum.UseVisualStyleBackColor = false;
            // 
            // pImage
            // 
            this.pImage.BackColor = System.Drawing.Color.Black;
            this.pImage.Location = new System.Drawing.Point(212, 157);
            this.pImage.Margin = new System.Windows.Forms.Padding(0);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(570, 272);
            this.pImage.TabIndex = 0;
            this.pImage.TabStop = false;
            // 
            // lblNameAlbum
            // 
            this.lblNameAlbum.AutoSize = true;
            this.lblNameAlbum.Location = new System.Drawing.Point(109, 70);
            this.lblNameAlbum.Name = "lblNameAlbum";
            this.lblNameAlbum.Size = new System.Drawing.Size(24, 27);
            this.lblNameAlbum.TabIndex = 8;
            this.lblNameAlbum.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lugar:";
            // 
            // LblPlaceAlbum
            // 
            this.LblPlaceAlbum.AutoSize = true;
            this.LblPlaceAlbum.Location = new System.Drawing.Point(83, 111);
            this.LblPlaceAlbum.Name = "LblPlaceAlbum";
            this.LblPlaceAlbum.Size = new System.Drawing.Size(24, 27);
            this.LblPlaceAlbum.TabIndex = 10;
            this.LblPlaceAlbum.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Descripción:";
            // 
            // lblDescriptionAlbum
            // 
            this.lblDescriptionAlbum.Location = new System.Drawing.Point(437, 70);
            this.lblDescriptionAlbum.Name = "lblDescriptionAlbum";
            this.lblDescriptionAlbum.Size = new System.Drawing.Size(333, 68);
            this.lblDescriptionAlbum.TabIndex = 12;
            this.lblDescriptionAlbum.Text = "...";
            // 
            // ViewAlbum
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(782, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDescriptionAlbum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblPlaceAlbum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNameAlbum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleHome);
            this.Controls.Add(this.btnDeleteAlbum);
            this.Controls.Add(this.btnEditAlbum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pImage);
            this.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ViewAlbum";
            this.Text = "Fotolva - nombre del album";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pImage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private Custom.ReundedButton btnEditAlbum;
        private Custom.ReundedButton btnDeleteAlbum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleHome;
        private System.Windows.Forms.Label lblNameAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPlaceAlbum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDescriptionAlbum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDescriptionImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNameImage;
    }
}