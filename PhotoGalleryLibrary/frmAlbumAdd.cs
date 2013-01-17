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
            if (this.txtTitle.Text != string.Empty)
            {
                Album newAlbum = new Album(this.txtTitle.Text, this.txtDescription.Text, this.txtAuthor.Text);
                newAlbum.MainImage = this.pbMainPhoto.Image;

                Photo newPhoto = new Photo(this.pbMainPhoto.Image);
                newPhoto.Title = newAlbum.Title;
                newPhoto.Author = newAlbum.Author;
                newPhoto.Describe = "Zdjęcie główne albumu";

                newAlbum.AddPhoto(newPhoto);

                parentGallery.GalleryObject.AddAlbum(newAlbum);
                parentGallery.RefreshAlbumsView();

                this.Close();
            }
            else
            {
                MessageBox.Show("Podaj tytuł albumu!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
