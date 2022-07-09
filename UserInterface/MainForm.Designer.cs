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
            this.pbZ1 = new System.Windows.Forms.PictureBox();
            this.pbZ2 = new System.Windows.Forms.PictureBox();
            this.pbZ3 = new System.Windows.Forms.PictureBox();
            this.pnlZvijezde = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZ3)).BeginInit();
            this.pnlZvijezde.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.listeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1207, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.settingsToolStripMenuItem.Text = "Postavke";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaIgračaToolStripMenuItem,
            this.listaUtakmiceToolStripMenuItem});
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.listeToolStripMenuItem.Text = "Liste";
            // 
            // listaIgračaToolStripMenuItem
            // 
            this.listaIgračaToolStripMenuItem.Name = "listaIgračaToolStripMenuItem";
            this.listaIgračaToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.listaIgračaToolStripMenuItem.Text = "Lista Igrača";
            this.listaIgračaToolStripMenuItem.Click += new System.EventHandler(this.ShowPlayerStatsList_Click);
            // 
            // listaUtakmiceToolStripMenuItem
            // 
            this.listaUtakmiceToolStripMenuItem.Name = "listaUtakmiceToolStripMenuItem";
            this.listaUtakmiceToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.listaUtakmiceToolStripMenuItem.Text = "Lista Utakmice";
            this.listaUtakmiceToolStripMenuItem.Click += new System.EventHandler(this.ShowMatchStatsList_Click);
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(15, 52);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(121, 24);
            this.cbTeams.TabIndex = 2;
            this.cbTeams.SelectedIndexChanged += new System.EventHandler(this.cbTeams_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timovi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Igrači:";
            // 
            // pnlIgraci
            // 
            this.pnlIgraci.AllowDrop = true;
            this.pnlIgraci.AutoScroll = true;
            this.pnlIgraci.BackColor = System.Drawing.Color.White;
            this.pnlIgraci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIgraci.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlIgraci.Location = new System.Drawing.Point(0, 118);
            this.pnlIgraci.Name = "pnlIgraci";
            this.pnlIgraci.Size = new System.Drawing.Size(1207, 738);
            this.pnlIgraci.TabIndex = 5;
            this.pnlIgraci.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlIgraci_DragDrop);
            this.pnlIgraci.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlIgraci_DragEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1026, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pogledaj favorite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenFavoritePlayers_Click);
            // 
            // pbZ1
            // 
            this.pbZ1.Image = global::UserInterface.Properties.Resources.prazna_zvijezda;
            this.pbZ1.InitialImage = global::UserInterface.Properties.Resources.prazna_zvijezda;
            this.pbZ1.Location = new System.Drawing.Point(3, 2);
            this.pbZ1.Name = "pbZ1";
            this.pbZ1.Size = new System.Drawing.Size(65, 50);
            this.pbZ1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZ1.TabIndex = 6;
            this.pbZ1.TabStop = false;
            // 
            // pbZ2
            // 
            this.pbZ2.Image = global::UserInterface.Properties.Resources.prazna_zvijezda;
            this.pbZ2.InitialImage = global::UserInterface.Properties.Resources.prazna_zvijezda;
            this.pbZ2.Location = new System.Drawing.Point(74, 2);
            this.pbZ2.Name = "pbZ2";
            this.pbZ2.Size = new System.Drawing.Size(65, 50);
            this.pbZ2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZ2.TabIndex = 10;
            this.pbZ2.TabStop = false;
            // 
            // pbZ3
            // 
            this.pbZ3.Image = global::UserInterface.Properties.Resources.prazna_zvijezda;
            this.pbZ3.InitialImage = global::UserInterface.Properties.Resources.prazna_zvijezda;
            this.pbZ3.Location = new System.Drawing.Point(145, 2);
            this.pbZ3.Name = "pbZ3";
            this.pbZ3.Size = new System.Drawing.Size(65, 50);
            this.pbZ3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbZ3.TabIndex = 11;
            this.pbZ3.TabStop = false;
            // 
            // pnlZvijezde
            // 
            this.pnlZvijezde.AllowDrop = true;
            this.pnlZvijezde.Controls.Add(this.pbZ1);
            this.pnlZvijezde.Controls.Add(this.pbZ3);
            this.pnlZvijezde.Controls.Add(this.pbZ2);
            this.pnlZvijezde.Location = new System.Drawing.Point(981, 31);
            this.pnlZvijezde.Name = "pnlZvijezde";
            this.pnlZvijezde.Size = new System.Drawing.Size(214, 52);
            this.pnlZvijezde.TabIndex = 12;
            this.pnlZvijezde.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlZvijezde_DragDrop);
            this.pnlZvijezde.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlZvijezde_DragEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 856);
            this.Controls.Add(this.pnlZvijezde);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlIgraci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTeams);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbZ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZ3)).EndInit();
            this.pnlZvijezde.ResumeLayout(false);
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