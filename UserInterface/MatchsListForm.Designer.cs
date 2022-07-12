namespace UserInterface
{
    partial class MatchsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchsListForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDolaznost = new System.Windows.Forms.RadioButton();
            this.rbLokacija = new System.Windows.Forms.RadioButton();
            this.pnlUtakmice = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.rbDolaznost);
            this.groupBox1.Controls.Add(this.rbLokacija);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rbDolaznost
            // 
            resources.ApplyResources(this.rbDolaznost, "rbDolaznost");
            this.rbDolaznost.Name = "rbDolaznost";
            this.rbDolaznost.TabStop = true;
            this.rbDolaznost.UseVisualStyleBackColor = true;
            this.rbDolaznost.CheckedChanged += new System.EventHandler(this.rbLokacija_CheckedChanged);
            // 
            // rbLokacija
            // 
            resources.ApplyResources(this.rbLokacija, "rbLokacija");
            this.rbLokacija.Name = "rbLokacija";
            this.rbLokacija.TabStop = true;
            this.rbLokacija.UseVisualStyleBackColor = true;
            this.rbLokacija.CheckedChanged += new System.EventHandler(this.rbLokacija_CheckedChanged);
            // 
            // pnlUtakmice
            // 
            resources.ApplyResources(this.pnlUtakmice, "pnlUtakmice");
            this.pnlUtakmice.Name = "pnlUtakmice";
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // MatchsListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlUtakmice);
            this.Name = "MatchsListForm";
            this.Load += new System.EventHandler(this.MatchsListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDolaznost;
        private System.Windows.Forms.RadioButton rbLokacija;
        private System.Windows.Forms.FlowLayoutPanel pnlUtakmice;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}