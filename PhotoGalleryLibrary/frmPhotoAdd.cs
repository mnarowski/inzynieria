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
        string pathToPhoto = string.Empty;

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
                        this.pathToPhoto = openImage.FileName;
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
                newPhoto.vtitle = this.txtTitle.Text;
                newPhoto.vauthor = this.txtAuthor.Text;
                newPhoto.vdescription = this.txtDescription.Text;
                try
                {
                    newPhoto.vimagepath = this.pathToPhoto;
                    newPhoto.valbumid = parentGallery.GetSelectedAlbumIcon().AlbumObject.vid;
                }
                catch (Exception) {
                    System.Windows.Forms.MessageBox.Show("Nie wybrano albumu lub obrazka do zdjęcia!");
                    return;
                }
                parentGallery.GetSelectedAlbumIcon().AlbumObject.AddPhoto(newPhoto);
                parentGallery.RefreshPhotosView();
                this.Close();
            }
            else
            {
                MessageBox.Show("Podaj tytuł zdjęcia!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmPhotoAdd_Load(object sender, EventArgs e)
        {
            //do nothing
        }
    }
}
