namespace UserInterface
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbHRV = new System.Windows.Forms.RadioButton();
            this.rbENG = new System.Windows.Forms.RadioButton();
            this.gbSpol = new System.Windows.Forms.GroupBox();
            this.rbZensko = new System.Windows.Forms.RadioButton();
            this.rbMusko = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbMusko = new System.Windows.Forms.PictureBox();
            this.btnHRV = new System.Windows.Forms.PictureBox();
            this.pbZensko = new System.Windows.Forms.PictureBox();
            this.btnENG = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbSpol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHRV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZensko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnENG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHRV);
            this.groupBox1.Controls.Add(this.rbENG);
            this.groupBox1.Location = new System.Drawing.Point(12, 601);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 53);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // rbHRV
            // 
            this.rbHRV.AutoSize = true;
            this.rbHRV.Location = new System.Drawing.Point(120, 21);
            this.rbHRV.Name = "rbHRV";
            this.rbHRV.Size = new System.Drawing.Size(77, 20);
            this.rbHRV.TabIndex = 8;
            this.rbHRV.TabStop = true;
            this.rbHRV.Text = "Hrvatski";
            this.rbHRV.UseVisualStyleBackColor = true;
            // 
            // rbENG
            // 
            this.rbENG.AutoSize = true;
            this.rbENG.Location = new System.Drawing.Point(561, 21);
            this.rbENG.Name = "rbENG";
            this.rbENG.Size = new System.Drawing.Size(80, 20);
            this.rbENG.TabIndex = 9;
            this.rbENG.TabStop = true;
            this.rbENG.Text = "Engleski";
            this.rbENG.UseVisualStyleBackColor = true;
            // 
            // gbSpol
            // 
            this.gbSpol.Controls.Add(this.rbZensko);
            this.gbSpol.Controls.Add(this.rbMusko);
            this.gbSpol.Location = new System.Drawing.Point(12, 380);
            this.gbSpol.Name = "gbSpol";
            this.gbSpol.Size = new System.Drawing.Size(765, 53);
            this.gbSpol.TabIndex = 19;
            this.gbSpol.TabStop = false;
            // 
            // rbZensko
            // 
            this.rbZensko.AutoSize = true;
            this.rbZensko.Location = new System.Drawing.Point(120, 21);
            this.rbZensko.Name = "rbZensko";
            this.rbZensko.Size = new System.Drawing.Size(135, 20);
            this.rbZensko.TabIndex = 8;
            this.rbZensko.TabStop = true;
            this.rbZensko.Text = "Žensko prvenstvo";
            this.rbZensko.UseVisualStyleBackColor = true;
            // 
            // rbMusko
            // 
            this.rbMusko.AutoSize = true;
            this.rbMusko.Location = new System.Drawing.Point(561, 21);
            this.rbMusko.Name = "rbMusko";
            this.rbMusko.Size = new System.Drawing.Size(130, 20);
            this.rbMusko.TabIndex = 9;
            this.rbMusko.TabStop = true;
            this.rbMusko.Text = "Muško prvenstvo";
            this.rbMusko.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(294, 660);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(194, 84);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbMusko
            // 
            this.pbMusko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMusko.Image = global::UserInterface.Properties.Resources.silueta_musko_np;
            this.pbMusko.Location = new System.Drawing.Point(455, 32);
            this.pbMusko.Name = "pbMusko";
            this.pbMusko.Size = new System.Drawing.Size(315, 342);
            this.pbMusko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMusko.TabIndex = 17;
            this.pbMusko.TabStop = false;
            // 
            // btnHRV
            // 
            this.btnHRV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHRV.Image = global::UserInterface.Properties.Resources.eng;
            this.btnHRV.Location = new System.Drawing.Point(462, 465);
            this.btnHRV.Name = "btnHRV";
            this.btnHRV.Size = new System.Drawing.Size(315, 130);
            this.btnHRV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHRV.TabIndex = 16;
            this.btnHRV.TabStop = false;
            // 
            // pbZensko
            // 
            this.pbZensko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbZensko.Image = global::UserInterface.Properties.Resources.zena;
            this.pbZensko.Location = new System.Drawing.Point(12, 32);
            this.pbZensko.Name = "pbZensko";
            this.pbZensko.Size = new System.Drawing.Size(315, 342);
            this.pbZensko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZensko.TabIndex = 15;
            this.pbZensko.TabStop = false;
            // 
            // btnENG
            // 
            this.btnENG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnENG.Image = global::UserInterface.Properties.Resources.cro;
            this.btnENG.Location = new System.Drawing.Point(12, 465);
            this.btnENG.Name = "btnENG";
            this.btnENG.Size = new System.Drawing.Size(315, 130);
            this.btnENG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnENG.TabIndex = 14;
            this.btnENG.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSpol);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbMusko);
            this.Controls.Add(this.btnHRV);
            this.Controls.Add(this.pbZensko);
            this.Controls.Add(this.btnENG);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSpol.ResumeLayout(false);
            this.gbSpol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHRV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZensko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnENG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHRV;
        private System.Windows.Forms.RadioButton rbENG;
        private System.Windows.Forms.GroupBox gbSpol;
        private System.Windows.Forms.RadioButton rbZensko;
        private System.Windows.Forms.RadioButton rbMusko;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbMusko;
        private System.Windows.Forms.PictureBox btnHRV;
        private System.Windows.Forms.PictureBox pbZensko;
        private System.Windows.Forms.PictureBox btnENG;
    }
}

