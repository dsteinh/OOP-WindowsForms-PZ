namespace UserInterface
{
    partial class RankListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankListForm));
            this.pnlIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbZutiKartoni = new System.Windows.Forms.RadioButton();
            this.rbGolovi = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIgraci
            // 
            this.pnlIgraci.AutoScroll = true;
            this.pnlIgraci.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlIgraci.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlIgraci.Location = new System.Drawing.Point(0, 98);
            this.pnlIgraci.Name = "pnlIgraci";
            this.pnlIgraci.Size = new System.Drawing.Size(605, 714);
            this.pnlIgraci.TabIndex = 0;
            this.pnlIgraci.WrapContents = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbZutiKartoni);
            this.groupBox1.Controls.Add(this.rbGolovi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 42);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sortiranja";
            // 
            // rbZutiKartoni
            // 
            this.rbZutiKartoni.AutoSize = true;
            this.rbZutiKartoni.Location = new System.Drawing.Point(495, 16);
            this.rbZutiKartoni.Name = "rbZutiKartoni";
            this.rbZutiKartoni.Size = new System.Drawing.Size(92, 20);
            this.rbZutiKartoni.TabIndex = 1;
            this.rbZutiKartoni.TabStop = true;
            this.rbZutiKartoni.Text = "Žuti kartoni";
            this.rbZutiKartoni.UseVisualStyleBackColor = true;
            this.rbZutiKartoni.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rbGolovi
            // 
            this.rbGolovi.AutoSize = true;
            this.rbGolovi.Location = new System.Drawing.Point(422, 16);
            this.rbGolovi.Name = "rbGolovi";
            this.rbGolovi.Size = new System.Drawing.Size(67, 20);
            this.rbGolovi.TabIndex = 0;
            this.rbGolovi.TabStop = true;
            this.rbGolovi.Text = "Golovi";
            this.rbGolovi.UseVisualStyleBackColor = true;
            this.rbGolovi.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(267, 60);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 3;
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
            // RankListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 812);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlIgraci);
            this.Name = "RankListForm";
            this.Text = "RankListForm";
            this.Load += new System.EventHandler(this.RankListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlIgraci;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbZutiKartoni;
        private System.Windows.Forms.RadioButton rbGolovi;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}