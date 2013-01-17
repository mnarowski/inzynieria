using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PhotoGalleryLibrary.Exceptions;

namespace PhotoGalleryLibrary.GUI
{
    public partial class PhotoGallery : UserControl
    {
        const int PhotosInWindowCount = 4;
        const int leftMargin = 5;
        const int topMargin = 5;
        const int scrollBarWidth = 25;
        int widthAlbumObject = 0;
        int heightAlbumObject = 0;
        int widthPhotoObject = 0;
        int heightPhotoObject = 0;

        AlbumsManager GalleryObjectSource;

        private int AlbumsCount
        {
            get
            {
                if (this.GalleryObjectSource != null)
                {
                    if (this.GalleryObjectSource.Albums != null)
                    {
                        return this.GalleryObjectSource.Albums.Count;
                    }
                    return 0;
                }

                return 0;
            }
        }

        public PhotoGallery()
        {
            InitializeComponent();

            //Albums Object Create
            widthAlbumObject = this.panelAlbums.Width - leftMargin - scrollBarWidth;
            heightAlbumObject = (9 * widthAlbumObject) / 12;

            //Photo Object Create
            heightPhotoObject = this.panelPhotos.Height - topMargin - scrollBarWidth;
            widthPhotoObject = (6 * heightPhotoObject) / 4;

            GalleryObjectSource = new AlbumsManager();
        }

        public AlbumsManager GalleryObject
        {
            set
            {
                this.GalleryObjectSource = value;
                RefreshAlbumsView();
            }
            get
            {
                return this.GalleryObjectSource;
            }
        }

        public void RefreshAlbumsView()
        {
            foreach (Control ctrl in this.panelAlbums.Controls)
            {
                if (ctrl is AlbumIcon)
                {
                    this.panelAlbums.Controls.Remove(ctrl);
                }
            }

            this.panelAlbums.AutoScrollPosition = new Point(0, 0);

            if (this.GalleryObjectSource != null)
            {
                if (this.GalleryObjectSource.Albums != null)
                {
                    int nextLocation = topMargin;

                    foreach (Album alb in this.GalleryObjectSource.Albums)
                    {
                        AlbumIcon albico = new AlbumIcon();
                        albico.Size = new Size(widthAlbumObject, heightAlbumObject);
                        albico.Location = new Point(leftMargin, nextLocation);
                        albico.Visible = true;
                        albico.AlbumClick += new AlbumIcon.AlbumIconClick(AlbumIcon_Click);
                        albico.ContextMenuStrip = this.cmAlbum;
                        albico.AlbumObject = alb;

                        this.panelAlbums.Controls.Add(albico);

                        nextLocation += heightAlbumObject + topMargin * 2;
                    }
                }
            }
        }

        private void AlbumIcon_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.panelAlbums.Controls)
            {
                if (ctrl is AlbumIcon)
                {
                    ((AlbumIcon)ctrl).Selected = false;
                }
            }

            ((AlbumIcon)sender).Selected = true;

            LoadPhotos(((AlbumIcon)sender).AlbumObject);
        }

        public AlbumIcon GetSelectedAlbumIcon()
        {
            AlbumIcon ico = null;

            foreach (Control ctrl in this.panelAlbums.Controls)
            {
                if (ctrl is AlbumIcon)
                {
                    ico = (AlbumIcon)ctrl;
                    return ico;
                }
            }
            return ico;
        }

        public void RefreshPhotosView()
        {
            AlbumIcon selectedAlbumIcon = GetSelectedAlbumIcon();

            if (selectedAlbumIcon != null)
            {
                LoadPhotos(selectedAlbumIcon.AlbumObject);
            }
        }

        public void LoadPhotos(Album album)
        {
            //remove all PhotoIcon objects
            foreach (Control ctrl in this.panelPhotos.Controls)
            {
                if (ctrl is PhotoIcon)
                {
                    this.panelPhotos.Controls.Remove(ctrl);
                }
            }

            this.MainPicture.Image = null;
            this.txtAuthor.Text = string.Empty;
            this.txtTitle.Text = string.Empty;
            this.txtDate.Text = string.Empty;

            if (album != null)
            {
                List<Photo> photosToLoad = album.Photos;

                this.panelPhotos.AutoScrollPosition = new Point(0, 0);

                int nextPhotoLocation = leftMargin;

                //create new PhotoIcon objects with photos from selected Album

                foreach (Photo pht in photosToLoad)
                {
                    PhotoIcon photo = new PhotoIcon();
                    photo.Size = new Size(widthPhotoObject, heightPhotoObject);
                    photo.Location = new Point(nextPhotoLocation, topMargin);
                    photo.Visible = true;
                    photo.PhotoObject = pht;
                    photo.PhotoClick += new PhotoIcon.PhotoIconClick(photo_Click);
                    photo.ContextMenuStrip = this.cmPhoto;

                    this.panelPhotos.Controls.Add(photo);

                    nextPhotoLocation += widthPhotoObject + leftMargin;
                }
            }
        }

        void photo_Click(object sender, EventArgs e)
        {
            PhotoIcon photoIco = ((PhotoIcon)sender);
            this.txtAuthor.Visible = false;
            this.txtDate.Visible = false;
            this.MainPicture.Image = photoIco.PhotoObject.ImageObject;
            this.txtAuthor.Text = photoIco.PhotoObject.Author;
            this.txtTitle.Text = photoIco.PhotoObject.Title;
            this.txtAuthor.Visible = true;
            this.txtDate.Visible = true;
            this.txtDate.Text = photoIco.PhotoObject.DateAdded.ToShortDateString();
        }

        public void AddAlbumObject(Album album)
        {
            if (GalleryObjectSource == null)
            {
                this.GalleryObjectSource = new AlbumsManager();
            }

            this.GalleryObjectSource.AddAlbum(album);

            RefreshAlbumsView();
        }

        public void DeleteSelectedAlbum()
        {
            AlbumIcon selectedAlbum = SelectedAlbum;
            
            if (selectedAlbum != null)
            {
                this.GalleryObjectSource.DeleteAlbum(selectedAlbum.AlbumObject);
                RefreshAlbumsView();
            }
            else
            {
                throw new NonSelectedAlbumException();
            }
        }

        public AlbumIcon SelectedAlbum
        {
            get
            {
                AlbumIcon ico = null;

                foreach (Control ctrl in this.panelAlbums.Controls)
                {
                    if (ctrl is AlbumIcon)
                    {
                        if (((AlbumIcon)ctrl).Selected == true)
                        {
                            return (AlbumIcon)ctrl;
                        }
                    }
                }

                return ico;
            }
        }

        private void MainPicture_DoubleClick(object sender, EventArgs e)
        {
            frmPhotoFullScreen fullScreen = new frmPhotoFullScreen(this.MainPicture.Image);
            fullScreen.Show();
        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            frmAlbumAdd newAlbum = new frmAlbumAdd(this);
            newAlbum.Show();
        }

        private void linkNewPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPhotoAdd newPhoto = new frmPhotoAdd(this);
            newPhoto.Show();
        }

        private void linkNewAlbum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAlbumAdd newAlbum = new frmAlbumAdd(this);
            newAlbum.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                ContextMenuStrip albumMenu = menuItem.Owner as ContextMenuStrip;

                if (albumMenu != null)
                {
                    Control controlSelected = albumMenu.SourceControl;

                    if (controlSelected is AlbumIcon)
                    {
                        Album albumToDelete = ((AlbumIcon)controlSelected).AlbumObject;

                        if (MessageBox.Show(string.Concat("Czy na pewno chcesz usunąć album \"", albumToDelete.Title, "\"?"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.GalleryObject.DeleteAlbum(albumToDelete);
                            RefreshAlbumsView();
                            LoadPhotos(null);
                        }
                    }
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                ContextMenuStrip albumMenu = menuItem.Owner as ContextMenuStrip;

                if (albumMenu != null)
                {
                    Control controlSelected = albumMenu.SourceControl;

                    if (controlSelected is PhotoIcon)
                    {
                        Photo photoToDelete = ((PhotoIcon)controlSelected).PhotoObject;

                        if (MessageBox.Show(string.Concat("Czy na pewno chcesz usunąć zdjęcie \"", photoToDelete.Title, "\"?"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            AlbumIcon selectedAlbumIco = GetSelectedAlbumIcon();
                            selectedAlbumIco.AlbumObject.DeletePhoto(photoToDelete);
                            LoadPhotos(selectedAlbumIco.AlbumObject);
                        }
                    }
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                ContextMenuStrip albumMenu = menuItem.Owner as ContextMenuStrip;

                if (albumMenu != null)
                {
                    Control controlSelected = albumMenu.SourceControl;

                    if (controlSelected is AlbumIcon)
                    {
                        Album albumToEdit = ((AlbumIcon)controlSelected).AlbumObject;

                        frmAlbumEdit al = new frmAlbumEdit(albumToEdit, this);
                        al.Show();
                    }
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                ContextMenuStrip photoMenu = menuItem.Owner as ContextMenuStrip;

                if (photoMenu != null)
                {
                    Control controlSelected = photoMenu.SourceControl;

                    if (controlSelected is PhotoIcon)
                    {
                        Photo photoToEdit = ((PhotoIcon)controlSelected).PhotoObject;

                        frmPhotoEdit al = new frmPhotoEdit(photoToEdit, this);
                        al.Show();
                    }
                }
            }
        }
    }
}
