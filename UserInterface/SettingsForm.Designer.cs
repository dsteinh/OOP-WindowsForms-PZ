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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.rbHRV);
            this.groupBox1.Controls.Add(this.rbENG);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rbHRV
            // 
            resources.ApplyResources(this.rbHRV, "rbHRV");
            this.rbHRV.Name = "rbHRV";
            this.rbHRV.TabStop = true;
            this.rbHRV.UseVisualStyleBackColor = true;
            // 
            // rbENG
            // 
            resources.ApplyResources(this.rbENG, "rbENG");
            this.rbENG.Name = "rbENG";
            this.rbENG.TabStop = true;
            this.rbENG.UseVisualStyleBackColor = true;
            // 
            // gbSpol
            // 
            resources.ApplyResources(this.gbSpol, "gbSpol");
            this.gbSpol.Controls.Add(this.rbZensko);
            this.gbSpol.Controls.Add(this.rbMusko);
            this.gbSpol.Name = "gbSpol";
            this.gbSpol.TabStop = false;
            // 
            // rbZensko
            // 
            resources.ApplyResources(this.rbZensko, "rbZensko");
            this.rbZensko.Name = "rbZensko";
            this.rbZensko.TabStop = true;
            this.rbZensko.UseVisualStyleBackColor = true;
            // 
            // rbMusko
            // 
            resources.ApplyResources(this.rbMusko, "rbMusko");
            this.rbMusko.Name = "rbMusko";
            this.rbMusko.TabStop = true;
            this.rbMusko.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbMusko
            // 
            resources.ApplyResources(this.pbMusko, "pbMusko");
            this.pbMusko.Image = global::UserInterface.Properties.Resources.silueta_musko_np;
            this.pbMusko.Name = "pbMusko";
            this.pbMusko.TabStop = false;
            // 
            // btnHRV
            // 
            resources.ApplyResources(this.btnHRV, "btnHRV");
            this.btnHRV.Image = global::UserInterface.Properties.Resources.eng;
            this.btnHRV.Name = "btnHRV";
            this.btnHRV.TabStop = false;
            // 
            // pbZensko
            // 
            resources.ApplyResources(this.pbZensko, "pbZensko");
            this.pbZensko.Image = global::UserInterface.Properties.Resources.zena;
            this.pbZensko.Name = "pbZensko";
            this.pbZensko.TabStop = false;
            // 
            // btnENG
            // 
            resources.ApplyResources(this.btnENG, "btnENG");
            this.btnENG.Image = global::UserInterface.Properties.Resources.cro;
            this.btnENG.Name = "btnENG";
            this.btnENG.TabStop = false;
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSpol);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbMusko);
            this.Controls.Add(this.btnHRV);
            this.Controls.Add(this.pbZensko);
            this.Controls.Add(this.btnENG);
            this.Name = "SettingsForm";
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

