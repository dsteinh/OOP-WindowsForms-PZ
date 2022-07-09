namespace UserInterface.User_controls
{
    partial class PlayerTableElement
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
            this.lblIme = new System.Windows.Forms.Label();
            this.lblZutiKartoni = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgSlika = new System.Windows.Forms.PictureBox();
            this.lblGolovi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(134, 59);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(131, 25);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime Prezime";
            // 
            // lblZutiKartoni
            // 
            this.lblZutiKartoni.AutoSize = true;
            this.lblZutiKartoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZutiKartoni.Location = new System.Drawing.Point(424, 87);
            this.lblZutiKartoni.Name = "lblZutiKartoni";
            this.lblZutiKartoni.Size = new System.Drawing.Size(36, 25);
            this.lblZutiKartoni.TabIndex = 4;
            this.lblZutiKartoni.Text = "10";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UserInterface.Properties.Resources.ZutiKarton;
            this.pictureBox3.Location = new System.Drawing.Point(466, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UserInterface.Properties.Resources.lopta;
            this.pictureBox2.Location = new System.Drawing.Point(466, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // imgSlika
            // 
            this.imgSlika.Image = global::UserInterface.Properties.Resources.dres;
            this.imgSlika.Location = new System.Drawing.Point(3, 3);
            this.imgSlika.Name = "imgSlika";
            this.imgSlika.Size = new System.Drawing.Size(125, 133);
            this.imgSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlika.TabIndex = 0;
            this.imgSlika.TabStop = false;
            // 
            // lblGolovi
            // 
            this.lblGolovi.AutoSize = true;
            this.lblGolovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolovi.Location = new System.Drawing.Point(424, 13);
            this.lblGolovi.Name = "lblGolovi";
            this.lblGolovi.Size = new System.Drawing.Size(36, 25);
            this.lblGolovi.TabIndex = 7;
            this.lblGolovi.Text = "10";
            // 
            // PlayerTableElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblGolovi);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblZutiKartoni);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.imgSlika);
            this.Name = "PlayerTableElement";
            this.Size = new System.Drawing.Size(593, 137);
            this.Load += new System.EventHandler(this.PlayerTableElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgSlika;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblZutiKartoni;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblGolovi;
    }
}
