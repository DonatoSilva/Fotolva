namespace Fotolva
{
    partial class NewAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAlbum));
            this.TitleHome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNameAlbum = new System.Windows.Forms.TextBox();
            this.lblNameAlbum = new System.Windows.Forms.Label();
            this.txtPlaceAlbum = new System.Windows.Forms.TextBox();
            this.lblPlaceAlbum = new System.Windows.Forms.Label();
            this.titleNewAlbum = new System.Windows.Forms.Label();
            this.dateTimeAlbum = new System.Windows.Forms.DateTimePicker();
            this.lblDateAlbum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescrptionAlbum = new System.Windows.Forms.Label();
            this.txtDescriptionAlbum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateAlbum = new Fotolva.Custom.ReundedButton();
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
            this.TitleHome.Size = new System.Drawing.Size(111, 39);
            this.TitleHome.TabIndex = 1;
            this.TitleHome.Text = "Fotolva";
            this.TitleHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fotolva.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(115, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtNameAlbum
            // 
            this.txtNameAlbum.Location = new System.Drawing.Point(17, 172);
            this.txtNameAlbum.Name = "txtNameAlbum";
            this.txtNameAlbum.Size = new System.Drawing.Size(435, 34);
            this.txtNameAlbum.TabIndex = 8;
            this.txtNameAlbum.TextChanged += new System.EventHandler(this.TxtNameAlbum_TextChanged);
            // 
            // lblNameAlbum
            // 
            this.lblNameAlbum.AutoSize = true;
            this.lblNameAlbum.Location = new System.Drawing.Point(12, 139);
            this.lblNameAlbum.Margin = new System.Windows.Forms.Padding(3);
            this.lblNameAlbum.Name = "lblNameAlbum";
            this.lblNameAlbum.Size = new System.Drawing.Size(89, 27);
            this.lblNameAlbum.TabIndex = 7;
            this.lblNameAlbum.Text = "Nombre:";
            this.lblNameAlbum.Click += new System.EventHandler(this.LblNameAlbum_Click);
            // 
            // txtPlaceAlbum
            // 
            this.txtPlaceAlbum.Location = new System.Drawing.Point(17, 245);
            this.txtPlaceAlbum.Name = "txtPlaceAlbum";
            this.txtPlaceAlbum.Size = new System.Drawing.Size(212, 34);
            this.txtPlaceAlbum.TabIndex = 10;
            // 
            // lblPlaceAlbum
            // 
            this.lblPlaceAlbum.AutoSize = true;
            this.lblPlaceAlbum.Location = new System.Drawing.Point(12, 212);
            this.lblPlaceAlbum.Margin = new System.Windows.Forms.Padding(3);
            this.lblPlaceAlbum.Name = "lblPlaceAlbum";
            this.lblPlaceAlbum.Size = new System.Drawing.Size(65, 27);
            this.lblPlaceAlbum.TabIndex = 9;
            this.lblPlaceAlbum.Text = "Lugar:";
            this.lblPlaceAlbum.Click += new System.EventHandler(this.LblPlaceAlbum_Click);
            // 
            // titleNewAlbum
            // 
            this.titleNewAlbum.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.titleNewAlbum.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleNewAlbum.Location = new System.Drawing.Point(17, 67);
            this.titleNewAlbum.Margin = new System.Windows.Forms.Padding(1);
            this.titleNewAlbum.Name = "titleNewAlbum";
            this.titleNewAlbum.Size = new System.Drawing.Size(435, 39);
            this.titleNewAlbum.TabIndex = 11;
            this.titleNewAlbum.Text = "Nuevo álbum";
            this.titleNewAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimeAlbum
            // 
            this.dateTimeAlbum.CustomFormat = "dd/MM/yyyy";
            this.dateTimeAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeAlbum.Location = new System.Drawing.Point(240, 245);
            this.dateTimeAlbum.Name = "dateTimeAlbum";
            this.dateTimeAlbum.Size = new System.Drawing.Size(212, 34);
            this.dateTimeAlbum.TabIndex = 12;
            this.dateTimeAlbum.Value = new System.DateTime(2023, 10, 11, 20, 17, 40, 0);
            // 
            // lblDateAlbum
            // 
            this.lblDateAlbum.AutoSize = true;
            this.lblDateAlbum.Location = new System.Drawing.Point(235, 212);
            this.lblDateAlbum.Margin = new System.Windows.Forms.Padding(3);
            this.lblDateAlbum.Name = "lblDateAlbum";
            this.lblDateAlbum.Size = new System.Drawing.Size(66, 27);
            this.lblDateAlbum.TabIndex = 13;
            this.lblDateAlbum.Text = "Fecha:";
            this.lblDateAlbum.Click += new System.EventHandler(this.LblDateAlbum_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(17, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 1);
            this.panel1.TabIndex = 14;
            // 
            // lblDescrptionAlbum
            // 
            this.lblDescrptionAlbum.AutoSize = true;
            this.lblDescrptionAlbum.Location = new System.Drawing.Point(12, 285);
            this.lblDescrptionAlbum.Margin = new System.Windows.Forms.Padding(3);
            this.lblDescrptionAlbum.Name = "lblDescrptionAlbum";
            this.lblDescrptionAlbum.Size = new System.Drawing.Size(118, 27);
            this.lblDescrptionAlbum.TabIndex = 15;
            this.lblDescrptionAlbum.Text = "Descripción:";
            this.lblDescrptionAlbum.Click += new System.EventHandler(this.LblDescrptionAlbum_Click);
            // 
            // txtDescriptionAlbum
            // 
            this.txtDescriptionAlbum.Location = new System.Drawing.Point(17, 324);
            this.txtDescriptionAlbum.Multiline = true;
            this.txtDescriptionAlbum.Name = "txtDescriptionAlbum";
            this.txtDescriptionAlbum.Size = new System.Drawing.Size(434, 247);
            this.txtDescriptionAlbum.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Text Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 591);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Primer paso para crear el album, aqui asignaras la informacion del album de fotos" +
    ". Ningun campo puede estar vacío.";
            // 
            // btnCreateAlbum
            // 
            this.btnCreateAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(169)))), ((int)(((byte)(211)))));
            this.btnCreateAlbum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(169)))), ((int)(((byte)(211)))));
            this.btnCreateAlbum.BorderRadius = 15;
            this.btnCreateAlbum.BorderSize = 0;
            this.btnCreateAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAlbum.FlatAppearance.BorderSize = 0;
            this.btnCreateAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAlbum.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAlbum.ForeColor = System.Drawing.Color.White;
            this.btnCreateAlbum.Image = global::Fotolva.Properties.Resources.disco;
            this.btnCreateAlbum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAlbum.Location = new System.Drawing.Point(327, 12);
            this.btnCreateAlbum.Name = "btnCreateAlbum";
            this.btnCreateAlbum.Size = new System.Drawing.Size(125, 39);
            this.btnCreateAlbum.TabIndex = 4;
            this.btnCreateAlbum.Text = "Guardar";
            this.btnCreateAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCreateAlbum.UseVisualStyleBackColor = false;
            this.btnCreateAlbum.Click += new System.EventHandler(this.BtnCreateAlbum_Click);
            // 
            // NewAlbum
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(464, 641);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescriptionAlbum);
            this.Controls.Add(this.lblDescrptionAlbum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDateAlbum);
            this.Controls.Add(this.dateTimeAlbum);
            this.Controls.Add(this.titleNewAlbum);
            this.Controls.Add(this.txtPlaceAlbum);
            this.Controls.Add(this.lblPlaceAlbum);
            this.Controls.Add(this.txtNameAlbum);
            this.Controls.Add(this.lblNameAlbum);
            this.Controls.Add(this.btnCreateAlbum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TitleHome);
            this.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "NewAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fotolva - Nuevo Album";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Custom.ReundedButton btnCreateAlbum;
        private System.Windows.Forms.TextBox txtNameAlbum;
        private System.Windows.Forms.Label lblNameAlbum;
        private System.Windows.Forms.TextBox txtPlaceAlbum;
        private System.Windows.Forms.Label lblPlaceAlbum;
        private System.Windows.Forms.Label titleNewAlbum;
        private System.Windows.Forms.DateTimePicker dateTimeAlbum;
        private System.Windows.Forms.Label lblDateAlbum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescrptionAlbum;
        private System.Windows.Forms.TextBox txtDescriptionAlbum;
        private System.Windows.Forms.Label label6;
    }
}