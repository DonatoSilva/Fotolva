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
            this.reundedButton1 = new Fotolva.Custom.ReundedButton();
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
            this.TitleHome.TabIndex = 0;
            this.TitleHome.Text = "Fotolva";
            this.TitleHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fotolva.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(97, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // reundedButton1
            // 
            this.reundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.reundedButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(164)))), ((int)(((byte)(211)))));
            this.reundedButton1.BorderRadius = 20;
            this.reundedButton1.BorderSize = 0;
            this.reundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reundedButton1.FlatAppearance.BorderSize = 0;
            this.reundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reundedButton1.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reundedButton1.ForeColor = System.Drawing.Color.White;
            this.reundedButton1.Image = global::Fotolva.Properties.Resources.plaza_mas;
            this.reundedButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reundedButton1.Location = new System.Drawing.Point(370, 10);
            this.reundedButton1.Name = "reundedButton1";
            this.reundedButton1.Size = new System.Drawing.Size(100, 39);
            this.reundedButton1.TabIndex = 3;
            this.reundedButton1.Text = "Nuevo";
            this.reundedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reundedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.reundedButton1.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.reundedButton1);
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
        private Custom.ReundedButton reundedButton1;
    }
}

