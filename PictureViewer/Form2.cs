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
   public partial class Form2 : Form
   {

      public Form2()
      {
         InitializeComponent();
         this.lblSizeMode.Text = $"Picture SizeMode: {this.pictureBox.SizeMode}";
      }

      int _index = 0;
      List<string> _listKoleksiImage = null;

      private void Form2_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.F1)
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
      }

      protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
      {
         if (keyData == Keys.Left)
         {
            if (_listKoleksiImage?.Count > 0)
            {
               if (_index > 0)
               {
                  this.pictureBox.Image = Image.FromFile(_listKoleksiImage[--_index]);
                  this.lblKeterangan.Text = $"({_index + 1}) {_listKoleksiImage[_index]})";
               }
            }
            return true;
         }
         else if (keyData == Keys.Right)
         {
            if (_listKoleksiImage?.Count > 0)
            {
               if (_index < _listKoleksiImage.Count - 1)
               {
                  this.pictureBox.Image = Image.FromFile(_listKoleksiImage[++_index]);
                  this.lblKeterangan.Text = $"({_index + 1}) {_listKoleksiImage[_index]})";
               }
            }
            return true;
         }
         else if (keyData == Keys.Up)
         {
            if (this.pictureBox.SizeMode != PictureBoxSizeMode.Normal) this.pictureBox.SizeMode -= 1;
            this.lblSizeMode.Text = $"Picture SizeMode: {this.pictureBox.SizeMode}";
            return true;
         }
         else if (keyData == Keys.Down)
         {
            if (this.pictureBox.SizeMode != PictureBoxSizeMode.Zoom) this.pictureBox.SizeMode += 1;
            this.lblSizeMode.Text = $"Picture SizeMode: {this.pictureBox.SizeMode}";
            return true;
         }
         else if (keyData == Keys.Home)
         {
            if (_listKoleksiImage?.Count > 0)
            {
               _index = 0;
               this.pictureBox.Image = Image.FromFile(_listKoleksiImage[_index]);
               this.lblKeterangan.Text = $"({_index + 1}) {_listKoleksiImage[_index]})";
            }
            return true;
         }
         else if (keyData == Keys.End)
         {
            if (_listKoleksiImage?.Count > 0)
            {
               _index = _listKoleksiImage.Count - 1;
               this.pictureBox.Image = Image.FromFile(_listKoleksiImage[_index]);
               this.lblKeterangan.Text = $"({_index + 1}) {_listKoleksiImage[_index]})";
            }
            return true;
         }
         return base.ProcessCmdKey(ref msg, keyData);
      }

   }
}
