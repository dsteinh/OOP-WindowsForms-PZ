namespace UserInterface
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaIgračaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaUtakmiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlZvijezde = new System.Windows.Forms.Panel();
            this.pbZ1 = new System.Windows.Forms.PictureBox();
            this.pbZ3 = new System.Windows.Forms.PictureBox();
            this.pbZ2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlZvijezde.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZ2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.listeToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaIgračaToolStripMenuItem,
            this.listaUtakmiceToolStripMenuItem});
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            resources.ApplyResources(this.listeToolStripMenuItem, "listeToolStripMenuItem");
            // 
            // listaIgračaToolStripMenuItem
            // 
            this.listaIgračaToolStripMenuItem.Name = "listaIgračaToolStripMenuItem";
            resources.ApplyResources(this.listaIgračaToolStripMenuItem, "listaIgračaToolStripMenuItem");
            this.listaIgračaToolStripMenuItem.Click += new System.EventHandler(this.ShowPlayerStatsList_Click);
            // 
            // listaUtakmiceToolStripMenuItem
            // 
            this.listaUtakmiceToolStripMenuItem.Name = "listaUtakmiceToolStripMenuItem";
            resources.ApplyResources(this.listaUtakmiceToolStripMenuItem, "listaUtakmiceToolStripMenuItem");
            this.listaUtakmiceToolStripMenuItem.Click += new System.EventHandler(this.ShowMatchStatsList_Click);
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            resources.ApplyResources(this.cbTeams, "cbTeams");
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.SelectedIndexChanged += new System.EventHandler(this.cbTeams_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pnlIgraci
            // 
            this.pnlIgraci.AllowDrop = true;
            resources.ApplyResources(this.pnlIgraci, "pnlIgraci");
            this.pnlIgraci.BackColor = System.Drawing.Color.White;
            this.pnlIgraci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIgraci.Name = "pnlIgraci";
            this.pnlIgraci.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlIgraci_DragEnter);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenFavoritePlayers_Click);
            // 
            // pnlZvijezde
            // 
            this.pnlZvijezde.AllowDrop = true;
            this.pnlZvijezde.Controls.Add(this.pbZ1);
            this.pnlZvijezde.Controls.Add(this.pbZ3);
            this.pnlZvijezde.Controls.Add(this.pbZ2);
            resources.ApplyResources(this.pnlZvijezde, "pnlZvijezde");
            this.pnlZvijezde.Name = "pnlZvijezde";
            this.pnlZvijezde.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlZvijezde_DragDrop);
            this.pnlZvijezde.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlZvijezde_DragEnter);
            // 
            // pbZ1
            // 
            this.pbZ1.Image = global::UserInterface.Properties.Resources.prazna_zvijezda;
            this.pbZ1.InitialImage = global::UserInterface.Properties.Resources.prazna_zvijezda;
            resources.ApplyResources(this.pbZ1, "pbZ1");
            this.pbZ1.Name = "pbZ1";
            this.pbZ1.TabStop = false;
            // 
            // pbZ3
            // 
            this.pbZ3.Image = global::UserInterface.Properties.Resources.prazna_zvijezda;
            this.pbZ3.InitialImage = global::UserInterface.Properties.Resources.prazna_zvijezda;
            resources.ApplyResources(this.pbZ3, "pbZ3");
            this.pbZ3.Name = "pbZ3";
            this.pbZ3.TabStop = false;
            // 
            // pbZ2
            // 
            this.pbZ2.Image = global::UserInterface.Properties.Resources.prazna_zvijezda;
            this.pbZ2.InitialImage = global::UserInterface.Properties.Resources.prazna_zvijezda;
            resources.ApplyResources(this.pbZ2, "pbZ2");
            this.pbZ2.Name = "pbZ2";
            this.pbZ2.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlZvijezde);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlIgraci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTeams);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlZvijezde.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbZ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZ2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaIgračaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaUtakmiceToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel pnlIgraci;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbZ1;
        private System.Windows.Forms.PictureBox pbZ2;
        private System.Windows.Forms.PictureBox pbZ3;
        private System.Windows.Forms.Panel pnlZvijezde;
    }
}