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
            this.groupBox1.Controls.Add(this.rbDolaznost);
            this.groupBox1.Controls.Add(this.rbLokacija);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 42);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sortiranja";
            // 
            // rbDolaznost
            // 
            this.rbDolaznost.AutoSize = true;
            this.rbDolaznost.Location = new System.Drawing.Point(607, 16);
            this.rbDolaznost.Name = "rbDolaznost";
            this.rbDolaznost.Size = new System.Drawing.Size(91, 20);
            this.rbDolaznost.TabIndex = 1;
            this.rbDolaznost.TabStop = true;
            this.rbDolaznost.Text = "Dolaznosti";
            this.rbDolaznost.UseVisualStyleBackColor = true;
            this.rbDolaznost.CheckedChanged += new System.EventHandler(this.rbLokacija_CheckedChanged);
            // 
            // rbLokacija
            // 
            this.rbLokacija.AutoSize = true;
            this.rbLokacija.Location = new System.Drawing.Point(527, 16);
            this.rbLokacija.Name = "rbLokacija";
            this.rbLokacija.Size = new System.Drawing.Size(79, 20);
            this.rbLokacija.TabIndex = 0;
            this.rbLokacija.TabStop = true;
            this.rbLokacija.Text = "Lokacija";
            this.rbLokacija.UseVisualStyleBackColor = true;
            this.rbLokacija.CheckedChanged += new System.EventHandler(this.rbLokacija_CheckedChanged);
            // 
            // pnlUtakmice
            // 
            this.pnlUtakmice.AutoScroll = true;
            this.pnlUtakmice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUtakmice.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlUtakmice.Location = new System.Drawing.Point(0, 91);
            this.pnlUtakmice.Name = "pnlUtakmice";
            this.pnlUtakmice.Size = new System.Drawing.Size(710, 683);
            this.pnlUtakmice.TabIndex = 2;
            this.pnlUtakmice.WrapContents = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(321, 62);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Isprintaj";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MatchsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 774);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlUtakmice);
            this.Name = "MatchsListForm";
            this.Text = "MatchsListForm";
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