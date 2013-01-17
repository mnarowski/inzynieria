using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhotoGalleryLibrary.GUI;
using System.Threading;

namespace PhotoGalleryLibrary
{
    public partial class frmAlbumEdit : Form
    {
        PhotoGallery parentGallery = null;
        AlbumIcon album = null;

        public frmAlbumEdit()
        {
            InitializeComponent();
        }

        public frmAlbumEdit(AlbumIcon albumToEdit, PhotoGallery parentPhotoGallery)
        {
            InitializeComponent();
            album = albumToEdit;

            this.txtTitle.Text = this.Text = album.Title;
            this.txtAuthor.Text = album.AlbumObject.Author;
            this.txtDescription.Text = album.AlbumObject.Describe;
            this.pbMainPhoto.Image = album.MainImage;

            parentGallery = parentPhotoGallery;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtTitle.Text != string.Empty)
            {
                if (MessageBox.Show("Czy zapisać zmiany?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.album.AlbumObject.Title = this.txtTitle.Text;
                    this.album.AlbumObject.Author = this.txtAuthor.Text;
                    this.album.AlbumObject.Describe = this.txtDescription.Text;
                    this.album.AlbumObject.MainImage = this.pbMainPhoto.Image;

                    this.album.Title = this.txtTitle.Text;
                    this.album.MainImage = this.pbMainPhoto.Image;

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Podaj tytuł albumu!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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
