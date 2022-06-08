namespace UserInterface
{
    partial class FavoritePlayersForm
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
            this.pnlOmiljeniIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlOmiljeniIgraci
            // 
            this.pnlOmiljeniIgraci.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOmiljeniIgraci.Location = new System.Drawing.Point(0, 0);
            this.pnlOmiljeniIgraci.Name = "pnlOmiljeniIgraci";
            this.pnlOmiljeniIgraci.Size = new System.Drawing.Size(1051, 345);
            this.pnlOmiljeniIgraci.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(854, 351);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 46);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FavoritePlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 409);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlOmiljeniIgraci);
            this.Name = "FavoritePlayersForm";
            this.Text = "FavoritePlayersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlOmiljeniIgraci;
        private System.Windows.Forms.Button btnSave;
    }
}