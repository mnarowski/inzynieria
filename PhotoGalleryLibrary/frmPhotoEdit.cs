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
        PhotoIcon photo = null;

        public frmPhotoEdit()
        {
            InitializeComponent();
        }

        public frmPhotoEdit(PhotoIcon photoToEdit, PhotoGallery parentGallery)
        {
            InitializeComponent();

            this.photo = photoToEdit;
            this.parentPhotoGallery = parentGallery;

            this.txtTitle.Text = photoToEdit.PhotoObject.Title;
            this.txtDescription.Text = photoToEdit.PhotoObject.Describe;
            this.txtAuthor.Text = photoToEdit.PhotoObject.Author;
            this.pbPhoto.Image = photoToEdit.PhotoObject.ImageObject;
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

                    photo.PhotoObject.Title = this.txtTitle.Text;
                    photo.PhotoObject.Author = this.txtAuthor.Text;
                    photo.PhotoObject.Describe = this.txtDescription.Text;
                    photo.PhotoObject.ImageObject = this.pbPhoto.Image;

                    photo.ImageObject = this.pbPhoto.Image;
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
