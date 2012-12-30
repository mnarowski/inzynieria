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
    public partial class frmAlbumAdd : Form
    {
        private PhotoGallery parentGallery = null;

        public frmAlbumAdd()
        {
            InitializeComponent();
        }

        public frmAlbumAdd(PhotoGallery photoGallery):this()
        {
            this.parentGallery = photoGallery;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Album newAlbum = new Album(this.txtTitle.Text, this.txtDescription.Text, this.txtAuthor.Text);
            newAlbum.MainImage = this.pbMainPhoto.Image;

            Photo newPhoto = new Photo(this.pbMainPhoto.Image);

            newAlbum.AddPhoto(newPhoto);

            parentGallery.GalleryObject.AddAlbum(newAlbum);
            parentGallery.GalleryObject = this.parentGallery.GalleryObject;

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
