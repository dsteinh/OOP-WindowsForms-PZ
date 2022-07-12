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
            resources.ApplyResources(this.pnlIgraci, "pnlIgraci");
            this.pnlIgraci.Name = "pnlIgraci";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbZutiKartoni);
            this.groupBox1.Controls.Add(this.rbGolovi);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rbZutiKartoni
            // 
            resources.ApplyResources(this.rbZutiKartoni, "rbZutiKartoni");
            this.rbZutiKartoni.Name = "rbZutiKartoni";
            this.rbZutiKartoni.TabStop = true;
            this.rbZutiKartoni.UseVisualStyleBackColor = true;
            this.rbZutiKartoni.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rbGolovi
            // 
            resources.ApplyResources(this.rbGolovi, "rbGolovi");
            this.rbGolovi.Name = "rbGolovi";
            this.rbGolovi.TabStop = true;
            this.rbGolovi.UseVisualStyleBackColor = true;
            this.rbGolovi.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
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
            // RankListForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlIgraci);
            this.Name = "RankListForm";
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