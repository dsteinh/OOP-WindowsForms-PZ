namespace UserInterface.User_controls
{
    partial class PlayerTile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBrojDresa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKapetan = new System.Windows.Forms.Label();
            this.imgFavorite = new System.Windows.Forms.PictureBox();
            this.lblImeIgraca = new System.Windows.Forms.Label();
            this.lblPozicija = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrojDresa
            // 
            this.lblBrojDresa.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojDresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojDresa.Location = new System.Drawing.Point(89, 111);
            this.lblBrojDresa.Name = "lblBrojDresa";
            this.lblBrojDresa.Size = new System.Drawing.Size(59, 25);
            this.lblBrojDresa.TabIndex = 1;
            this.lblBrojDresa.Text = "25";
            this.lblBrojDresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBrojDresa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBrojDresa_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.dres1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBrojDresa_MouseDown);
            // 
            // lblKapetan
            // 
            this.lblKapetan.AutoSize = true;
            this.lblKapetan.BackColor = System.Drawing.Color.White;
            this.lblKapetan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKapetan.Location = new System.Drawing.Point(3, 3);
            this.lblKapetan.Name = "lblKapetan";
            this.lblKapetan.Size = new System.Drawing.Size(27, 25);
            this.lblKapetan.TabIndex = 8;
            this.lblKapetan.Text = "K";
            // 
            // imgFavorite
            // 
            this.imgFavorite.Image = global::UserInterface.Properties.Resources.puna_zvijezda;
            this.imgFavorite.Location = new System.Drawing.Point(192, 3);
            this.imgFavorite.Name = "imgFavorite";
            this.imgFavorite.Size = new System.Drawing.Size(35, 25);
            this.imgFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFavorite.TabIndex = 9;
            this.imgFavorite.TabStop = false;
            this.imgFavorite.Click += new System.EventHandler(this.imgFavorite_Click);
            // 
            // lblImeIgraca
            // 
            this.lblImeIgraca.BackColor = System.Drawing.Color.White;
            this.lblImeIgraca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblImeIgraca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeIgraca.Location = new System.Drawing.Point(0, 241);
            this.lblImeIgraca.Name = "lblImeIgraca";
            this.lblImeIgraca.Size = new System.Drawing.Size(233, 39);
            this.lblImeIgraca.TabIndex = 14;
            this.lblImeIgraca.Text = "Ime Igraca";
            this.lblImeIgraca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPozicija
            // 
            this.lblPozicija.BackColor = System.Drawing.Color.White;
            this.lblPozicija.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPozicija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozicija.Location = new System.Drawing.Point(0, 280);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(233, 40);
            this.lblPozicija.TabIndex = 15;
            this.lblPozicija.Text = "Pozicija";
            this.lblPozicija.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblImeIgraca);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.lblKapetan);
            this.Controls.Add(this.imgFavorite);
            this.Controls.Add(this.lblBrojDresa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PlayerTile";
            this.Size = new System.Drawing.Size(233, 320);
            this.Load += new System.EventHandler(this.PlayerTile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFavorite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBrojDresa;
        private System.Windows.Forms.Label lblKapetan;
        private System.Windows.Forms.PictureBox imgFavorite;
        private System.Windows.Forms.Label lblImeIgraca;
        private System.Windows.Forms.Label lblPozicija;
    }
}
