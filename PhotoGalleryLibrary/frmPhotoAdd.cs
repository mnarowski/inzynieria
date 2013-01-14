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
    public partial class frmPhotoAdd : Form
    {
        PhotoGallery parentGallery = null;

        public frmPhotoAdd()
        {
            InitializeComponent();
        }

        public frmPhotoAdd(PhotoGallery photoGallery)
        {
            InitializeComponent();
            this.parentGallery = photoGallery;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();

            using (openImage)
            {
                try
                {
                    if (openImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.pbPhoto.Image = Image.FromFile(openImage.FileName);
                    }
                }
                catch
                {
                    MessageBox.Show("Błąd podczas owtierania zdjęcia!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtTitle.Text != string.Empty)
            {
                Photo newPhoto = new Photo(this.pbPhoto.Image);
                newPhoto.Title = this.txtTitle.Text;
                newPhoto.Author = this.txtAuthor.Text;
                newPhoto.Describe = this.txtDescription.Text;

                parentGallery.GetSelectedAlbumIcon().AlbumObject.AddPhoto(newPhoto);
                parentGallery.RefreshPhotosView();
                this.Close();
            }
            else
            {
                MessageBox.Show("Podaj tytuł zdjęcia!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
