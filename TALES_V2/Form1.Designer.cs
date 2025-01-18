namespace TALES_V2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.taleListPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.lbGR_EN = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.taleListPnl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picBook, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.09179F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.90821F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1340, 583);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // taleListPnl
            // 
            this.taleListPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taleListPnl.AutoScroll = true;
            this.taleListPnl.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.taleListPnl.Location = new System.Drawing.Point(3, 2);
            this.taleListPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taleListPnl.Name = "taleListPnl";
            this.tableLayoutPanel1.SetRowSpan(this.taleListPnl, 2);
            this.taleListPnl.Size = new System.Drawing.Size(440, 579);
            this.taleListPnl.TabIndex = 0;
            // 
            // picBook
            // 
            this.picBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBook.BackgroundImage = global::TALES_V2.Properties.Resources.BookCoverIcon;
            this.picBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBook.Location = new System.Drawing.Point(450, 4);
            this.picBook.Margin = new System.Windows.Forms.Padding(4);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(438, 476);
            this.picBook.TabIndex = 0;
            this.picBook.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnVolume);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.lbGR_EN);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnLanguage);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(449, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 93);
            this.panel1.TabIndex = 1;
            // 
            // btnVolume
            // 
            this.btnVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolume.BackgroundImage = global::TALES_V2.Properties.Resources.volumeIcon;
            this.btnVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolume.Location = new System.Drawing.Point(339, 12);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(50, 50);
            this.btnVolume.TabIndex = 4;
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // btnForward
            // 
            this.btnForward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.BackgroundImage = global::TALES_V2.Properties.Resources.fwIcon;
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForward.Location = new System.Drawing.Point(250, 12);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(50, 50);
            this.btnForward.TabIndex = 3;
            this.btnForward.UseVisualStyleBackColor = false;
            // 
            // lbGR_EN
            // 
            this.lbGR_EN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbGR_EN.AutoSize = true;
            this.lbGR_EN.BackColor = System.Drawing.Color.Transparent;
            this.lbGR_EN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGR_EN.ForeColor = System.Drawing.Color.BurlyWood;
            this.lbGR_EN.Location = new System.Drawing.Point(5, 22);
            this.lbGR_EN.Name = "lbGR_EN";
            this.lbGR_EN.Size = new System.Drawing.Size(39, 25);
            this.lbGR_EN.TabIndex = 2;
            this.lbGR_EN.Text = "EN";
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPlay.BackgroundImage = global::TALES_V2.Properties.Resources.playIcon;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(194, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBack.BackgroundImage = global::TALES_V2.Properties.Resources.bwIcon;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(138, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnLanguage
            // 
            this.btnLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnLanguage.BackgroundImage = global::TALES_V2.Properties.Resources.enIcon;
            this.btnLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLanguage.Location = new System.Drawing.Point(50, 12);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(50, 50);
            this.btnLanguage.TabIndex = 0;
            this.btnLanguage.UseVisualStyleBackColor = true;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TALES_V2.Properties.Resources.bgIcon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1342, 586);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel taleListPnl;
        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Label lbGR_EN;
    }
}

