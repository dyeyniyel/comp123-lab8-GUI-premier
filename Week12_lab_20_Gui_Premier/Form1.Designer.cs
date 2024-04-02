namespace Week12_lab_20_Gui_Premier
{
    partial class Form1
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lst = new System.Windows.Forms.ListBox();
            this.lblConstituent = new System.Windows.Forms.Label();
            this.lblParty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pic.Location = new System.Drawing.Point(27, 53);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(357, 327);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblLife
            // 
            this.lblLife.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLife.AutoSize = true;
            this.lblLife.Location = new System.Drawing.Point(23, 333);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(35, 20);
            this.lblLife.TabIndex = 2;
            this.lblLife.Text = "Life";
            // 
            // lblTerm
            // 
            this.lblTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(23, 364);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(45, 20);
            this.lblTerm.TabIndex = 3;
            this.lblTerm.Text = "Term";
            // 
            // lst
            // 
            this.lst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 20;
            this.lst.Location = new System.Drawing.Point(507, 12);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(257, 444);
            this.lst.TabIndex = 4;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            this.lst.SelectedValueChanged += new System.EventHandler(this.lst_SelectedValueChanged);
            // 
            // lblConstituent
            // 
            this.lblConstituent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConstituent.AutoSize = true;
            this.lblConstituent.Location = new System.Drawing.Point(23, 396);
            this.lblConstituent.Name = "lblConstituent";
            this.lblConstituent.Size = new System.Drawing.Size(91, 20);
            this.lblConstituent.TabIndex = 5;
            this.lblConstituent.Text = "Constituent";
            // 
            // lblParty
            // 
            this.lblParty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblParty.AutoSize = true;
            this.lblParty.Location = new System.Drawing.Point(23, 429);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(45, 20);
            this.lblParty.TabIndex = 6;
            this.lblParty.Text = "Party";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 579);
            this.Controls.Add(this.lblParty);
            this.Controls.Add(this.lblConstituent);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Label lblConstituent;
        private System.Windows.Forms.Label lblParty;
    }
}

