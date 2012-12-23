using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhotoGalleryLibrary.GUI;

namespace PhotoGalleryLibrary
{
    public partial class frmAlbumEdit : Form
    {
        private Album parentAlbum = null;

        public frmAlbumEdit()
        {
            InitializeComponent();
        }

        public frmAlbumEdit(Album photoGallery)
            : this()
        {
            this.parentAlbum = photoGallery;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zapisać zmiany w albumie?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Album newAlbum = new Album(this.txtTitle.Text);

                newAlbum.Describe = this.txtDescription.Text;
                newAlbum.MainImage = this.pbMainPhoto.Image;

                this.Close();
            }

            this.Close();
        }

        private void linkAddChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();

            using (openImage)
            {
                try
                {
                    if (openImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.pbMainPhoto.Image = Image.FromFile(openImage.FileName);
                    }
                }
                catch
                {
                    MessageBox.Show("Błąd podczas owtierania zdjęcia!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
