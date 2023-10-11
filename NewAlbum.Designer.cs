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
            this.reundedButton1 = new Fotolva.Custom.ReundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.TitleHome.Size = new System.Drawing.Size(88, 39);
            this.TitleHome.TabIndex = 1;
            this.TitleHome.Text = "Fotolva";
            this.TitleHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reundedButton1
            // 
            this.reundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(169)))), ((int)(((byte)(211)))));
            this.reundedButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(169)))), ((int)(((byte)(211)))));
            this.reundedButton1.BorderRadius = 15;
            this.reundedButton1.BorderSize = 0;
            this.reundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reundedButton1.FlatAppearance.BorderSize = 0;
            this.reundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reundedButton1.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reundedButton1.ForeColor = System.Drawing.Color.White;
            this.reundedButton1.Image = global::Fotolva.Properties.Resources.disco;
            this.reundedButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reundedButton1.Location = new System.Drawing.Point(339, 12);
            this.reundedButton1.Name = "reundedButton1";
            this.reundedButton1.Size = new System.Drawing.Size(113, 39);
            this.reundedButton1.TabIndex = 4;
            this.reundedButton1.Text = "Guardar";
            this.reundedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reundedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.reundedButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fotolva.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(93, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // NewAlbum
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(464, 641);
            this.Controls.Add(this.reundedButton1);
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

        }

        #endregion

        private System.Windows.Forms.Label TitleHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Custom.ReundedButton reundedButton1;
    }
}