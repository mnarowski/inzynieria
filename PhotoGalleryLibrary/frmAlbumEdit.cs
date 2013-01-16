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
        PhotoGallery parentGallery = null;
        Album album = null;

        public frmAlbumEdit()
        {
            InitializeComponent();
        }

        public frmAlbumEdit(Album albumToEdit, PhotoGallery parentPhotoGallery)
        {
            InitializeComponent();
            album = albumToEdit;

            this.txtTitle.Text = albumToEdit.Title;
            this.txtAuthor.Text = albumToEdit.Author;
            this.txtDescription.Text = albumToEdit.Describe;
            this.pbMainPhoto.Image = albumToEdit.MainImage;

            parentGallery = parentPhotoGallery;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtTitle.Text != string.Empty)
            {
                if (MessageBox.Show("Czy zapisać zmiany?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.album.Title = this.txtTitle.Text;
                    this.album.Author = this.txtAuthor.Text;
                    this.album.Describe = this.txtDescription.Text;
                    this.album.MainImage = this.pbMainPhoto.Image;

                    parentGallery.RefreshAlbumsView();

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
