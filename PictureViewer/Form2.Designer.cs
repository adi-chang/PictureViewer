namespace PictureViewer
{
   partial class Form2
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
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.lblKeterangan = new System.Windows.Forms.ToolStripStatusLabel();
         this.pictureBox = new System.Windows.Forms.PictureBox();
         this.lblNamaFolder = new System.Windows.Forms.Label();
         this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
         this.label1 = new System.Windows.Forms.Label();
         this.lblSizeMode = new System.Windows.Forms.Label();
         this.statusStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
         this.SuspendLayout();
         // 
         // statusStrip1
         // 
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblKeterangan});
         this.statusStrip1.Location = new System.Drawing.Point(0, 589);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(1064, 22);
         this.statusStrip1.TabIndex = 17;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // lblKeterangan
         // 
         this.lblKeterangan.Name = "lblKeterangan";
         this.lblKeterangan.Size = new System.Drawing.Size(0, 17);
         // 
         // pictureBox
         // 
         this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
         this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.pictureBox.Location = new System.Drawing.Point(12, 93);
         this.pictureBox.Name = "pictureBox";
         this.pictureBox.Size = new System.Drawing.Size(1040, 487);
         this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox.TabIndex = 16;
         this.pictureBox.TabStop = false;
         // 
         // lblNamaFolder
         // 
         this.lblNamaFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lblNamaFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblNamaFolder.Location = new System.Drawing.Point(12, 6);
         this.lblNamaFolder.Name = "lblNamaFolder";
         this.lblNamaFolder.Size = new System.Drawing.Size(1040, 23);
         this.lblNamaFolder.TabIndex = 11;
         this.lblNamaFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // label1
         // 
         this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 29);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(1040, 36);
         this.label1.TabIndex = 18;
         this.label1.Text = "F1 => browse folder ; Left Arrow/Right Arrow => Navigasi ; Home => Move To First " +
    "Pict, End => Move To Last Pict ; Up Arrow/Down Arrow => Change Picture SizeMode";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblSizeMode
         // 
         this.lblSizeMode.AutoSize = true;
         this.lblSizeMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblSizeMode.Location = new System.Drawing.Point(9, 77);
         this.lblSizeMode.Name = "lblSizeMode";
         this.lblSizeMode.Size = new System.Drawing.Size(122, 13);
         this.lblSizeMode.TabIndex = 19;
         this.lblSizeMode.Text = "{ keterangan sizemode }";
         // 
         // Form2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1064, 611);
         this.Controls.Add(this.lblSizeMode);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.pictureBox);
         this.Controls.Add(this.lblNamaFolder);
         this.KeyPreview = true;
         this.Name = "Form2";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Picture Viewer";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel lblKeterangan;
      private System.Windows.Forms.PictureBox pictureBox;
      private System.Windows.Forms.Label lblNamaFolder;
      private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label lblSizeMode;
   }
}