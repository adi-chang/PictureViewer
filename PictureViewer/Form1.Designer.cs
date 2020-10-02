namespace PictureViewer
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
         this.btnOpenFolder = new System.Windows.Forms.Button();
         this.lblNamaFolder = new System.Windows.Forms.Label();
         this.btnFirst = new System.Windows.Forms.Button();
         this.btnPrev = new System.Windows.Forms.Button();
         this.btnNext = new System.Windows.Forms.Button();
         this.btnLast = new System.Windows.Forms.Button();
         this.pictureBox = new System.Windows.Forms.PictureBox();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.lblKeterangan = new System.Windows.Forms.ToolStripStatusLabel();
         this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
         this.cboMode = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
         this.statusStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnOpenFolder
         // 
         this.btnOpenFolder.Location = new System.Drawing.Point(12, 12);
         this.btnOpenFolder.Name = "btnOpenFolder";
         this.btnOpenFolder.Size = new System.Drawing.Size(75, 23);
         this.btnOpenFolder.TabIndex = 0;
         this.btnOpenFolder.Text = "Open Folder";
         this.btnOpenFolder.UseVisualStyleBackColor = true;
         this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
         // 
         // lblNamaFolder
         // 
         this.lblNamaFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lblNamaFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblNamaFolder.Location = new System.Drawing.Point(93, 12);
         this.lblNamaFolder.Name = "lblNamaFolder";
         this.lblNamaFolder.Size = new System.Drawing.Size(579, 23);
         this.lblNamaFolder.TabIndex = 1;
         this.lblNamaFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // btnFirst
         // 
         this.btnFirst.Location = new System.Drawing.Point(12, 49);
         this.btnFirst.Name = "btnFirst";
         this.btnFirst.Size = new System.Drawing.Size(41, 23);
         this.btnFirst.TabIndex = 2;
         this.btnFirst.Text = "|<";
         this.btnFirst.UseVisualStyleBackColor = true;
         this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
         // 
         // btnPrev
         // 
         this.btnPrev.Location = new System.Drawing.Point(59, 49);
         this.btnPrev.Name = "btnPrev";
         this.btnPrev.Size = new System.Drawing.Size(41, 23);
         this.btnPrev.TabIndex = 3;
         this.btnPrev.Text = "<<";
         this.btnPrev.UseVisualStyleBackColor = true;
         this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
         // 
         // btnNext
         // 
         this.btnNext.Location = new System.Drawing.Point(106, 49);
         this.btnNext.Name = "btnNext";
         this.btnNext.Size = new System.Drawing.Size(41, 23);
         this.btnNext.TabIndex = 4;
         this.btnNext.Text = ">>";
         this.btnNext.UseVisualStyleBackColor = true;
         this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
         // 
         // btnLast
         // 
         this.btnLast.Location = new System.Drawing.Point(153, 49);
         this.btnLast.Name = "btnLast";
         this.btnLast.Size = new System.Drawing.Size(41, 23);
         this.btnLast.TabIndex = 5;
         this.btnLast.Text = ">|";
         this.btnLast.UseVisualStyleBackColor = true;
         this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
         // 
         // pictureBox
         // 
         this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
         this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.pictureBox.Location = new System.Drawing.Point(12, 78);
         this.pictureBox.Name = "pictureBox";
         this.pictureBox.Size = new System.Drawing.Size(660, 358);
         this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox.TabIndex = 6;
         this.pictureBox.TabStop = false;
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblKeterangan});
         this.statusStrip1.Location = new System.Drawing.Point(0, 439);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(684, 22);
         this.statusStrip1.TabIndex = 7;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // lblKeterangan
         // 
         this.lblKeterangan.Name = "lblKeterangan";
         this.lblKeterangan.Size = new System.Drawing.Size(0, 17);
         // 
         // cboMode
         // 
         this.cboMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cboMode.FormattingEnabled = true;
         this.cboMode.Location = new System.Drawing.Point(551, 48);
         this.cboMode.Name = "cboMode";
         this.cboMode.Size = new System.Drawing.Size(121, 24);
         this.cboMode.TabIndex = 8;
         this.cboMode.SelectedIndexChanged += new System.EventHandler(this.cboMode_SelectedIndexChanged);
         // 
         // label1
         // 
         this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(445, 48);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(100, 23);
         this.label1.TabIndex = 9;
         this.label1.Text = "Mode";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(684, 461);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.cboMode);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.pictureBox);
         this.Controls.Add(this.btnLast);
         this.Controls.Add(this.btnNext);
         this.Controls.Add(this.btnPrev);
         this.Controls.Add(this.btnFirst);
         this.Controls.Add(this.lblNamaFolder);
         this.Controls.Add(this.btnOpenFolder);
         this.KeyPreview = true;
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Picture Viewer";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOpenFolder;
    private System.Windows.Forms.Label lblNamaFolder;
    private System.Windows.Forms.Button btnFirst;
    private System.Windows.Forms.Button btnPrev;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Button btnLast;
    private System.Windows.Forms.PictureBox pictureBox;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblKeterangan;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
      private System.Windows.Forms.ComboBox cboMode;
      private System.Windows.Forms.Label label1;
   }
}

