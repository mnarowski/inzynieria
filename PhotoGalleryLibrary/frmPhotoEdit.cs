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
    public partial class frmPhotoEdit : Form
    {
        PhotoGallery parentPhotoGallery = null;
        Photo photo = null;

        public frmPhotoEdit()
        {
            InitializeComponent();
        }

        public frmPhotoEdit(Photo photoToEdit, PhotoGallery parentGallery)
        {
            InitializeComponent();

            this.photo = photoToEdit;
            this.parentPhotoGallery = parentGallery;

            this.txtTitle.Text = photoToEdit.Title;
            this.txtDescription.Text = photoToEdit.Describe;
            this.txtAuthor.Text = photoToEdit.Author;
            this.pbPhoto.Image = photoToEdit.ImageObject;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtTitle.Text != string.Empty)
            {
                if (MessageBox.Show("Czy chcesz zapisać zmiany?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    photo.Title = this.txtTitle.Text;
                    photo.Author = this.txtAuthor.Text;
                    photo.Describe = this.txtDescription.Text;
                    photo.ImageObject = this.pbPhoto.Image;

                    //parentPhotoGallery.GetSelectedAlbumIcon().AlbumObject.AddPhoto(photo);
                    parentPhotoGallery.RefreshPhotosView();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Podaj tytuł zdjęcia!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
