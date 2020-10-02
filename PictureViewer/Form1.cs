using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         this.cboMode.Items.Add(PictureBoxSizeMode.Normal);
         this.cboMode.Items.Add(PictureBoxSizeMode.StretchImage);
         this.cboMode.Items.Add(PictureBoxSizeMode.AutoSize);
         this.cboMode.Items.Add(PictureBoxSizeMode.CenterImage);
         this.cboMode.Items.Add(PictureBoxSizeMode.Zoom);
         this.cboMode.SelectedItem = this.pictureBox.SizeMode;
      }


      int _index = 0;
      List<string> _listKoleksiImage = null;

      private void btnOpenFolder_Click(object sender, EventArgs e)
      {
         try
         {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
               string path = this.folderBrowserDialog.SelectedPath;
               this.lblNamaFolder.Text = path;
               var items = Directory.EnumerateFiles(path, "*.jpg", SearchOption.TopDirectoryOnly);
               _listKoleksiImage = items.ToList();
               _index = 0;
               this.pictureBox.Image = Image.FromFile(_listKoleksiImage[_index]);
               this.lblKeterangan.Text = $"({_index + 1}) {_listKoleksiImage[_index]})";
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      private void btnFirst_Click(object sender, EventArgs e)
      {
         if (_listKoleksiImage?.Count > 0)
         {
            _index = 0;
            this.pictureBox.Image = Image.FromFile(_listKoleksiImage[_index]);
            this.lblKeterangan.Text = $"({_index + 1}) {_listKoleksiImage[_index]})";
         }
      }

      private void btnPrev_Click(object sender, EventArgs e)
      {
         if (_listKoleksiImage?.Count > 0)
         {
            if (_index > 0)
            {
               this.pictureBox.Image = Image.FromFile(_listKoleksiImage[--_index]);
               this.lblKeterangan.Text = $"({_index + 1}) {_listKoleksiImage[_index]})";
            }
         }
      }

      private void btnNext_Click(object sender, EventArgs e)
      {
         if (_listKoleksiImage?.Count > 0)
         {
            if (_index < _listKoleksiImage.Count - 1)
            {
               this.pictureBox.Image = Image.FromFile(_listKoleksiImage[++_index]);
               this.lblKeterangan.Text = $"({_index + 1}) {_listKoleksiImage[_index]})";
            }
         }
      }

      private void btnLast_Click(object sender, EventArgs e)
      {
         if (_listKoleksiImage?.Count > 0)
         {
            _index = _listKoleksiImage.Count - 1;
            this.pictureBox.Image = Image.FromFile(_listKoleksiImage[_index]);
            this.lblKeterangan.Text = $"({_index + 1}) {_listKoleksiImage[_index]})";
         }
      }

      protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         if (keyData == Keys.Left)
         {
            this.btnPrev_Click(null, null);
            return true;
         }
         else if (keyData == Keys.Right)
         {
            this.btnNext_Click(null, null);
            return true;
         }
         return base.ProcessCmdKey(ref msg, keyData);
      }

      private void cboMode_SelectedIndexChanged(object sender, EventArgs e)
      {
         this.pictureBox.SizeMode = (PictureBoxSizeMode)this.cboMode.SelectedItem;
      }
   }
}
