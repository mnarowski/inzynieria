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
        readonly int widthAlbumObject = 0;
        readonly int heightAlbumObject = 0;
        readonly int widthPhotoObject = 0;
        readonly int heightPhotoObject = 0;

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
            widthPhotoObject = (16 * heightPhotoObject) / 9;

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

        private void RefreshAlbumsView()
        {
            foreach (Control ctrl in this.panelAlbums.Controls)
            {
                if (ctrl is AlbumIcon)
                {
                    this.panelAlbums.Controls.Remove(ctrl);
                }
            }

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
                        albico.AlbumObject = alb;

                        this.panelAlbums.Controls.Add(albico);

                        nextLocation += heightAlbumObject + topMargin;
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

        private void LoadPhotos(Album album)
        {
            List<Photo> photosToLoad = album.Photos;

            //remove all PhotoIcon objects
            foreach (Control ctrl in this.panelPhotos.Controls)
            {
                if (ctrl is PhotoIcon)
                {
                    this.panelPhotos.Controls.Remove(ctrl);
                }
            }

            int nextPhotoLocation = leftMargin;

            //create new PhotoIcon objects with photos from selected Album

            foreach (Photo pht in photosToLoad)
            {
                PhotoIcon photo= new PhotoIcon();
                photo.Size = new Size(widthPhotoObject, heightPhotoObject);
                photo.Location = new Point(nextPhotoLocation, topMargin);
                photo.Visible = true;
                photo.PhotoObject = pht;
                photo.PhotoClick += new PhotoIcon.PhotoIconClick(photo_Click);

                this.panelPhotos.Controls.Add(photo);

                nextPhotoLocation += widthPhotoObject + leftMargin;
            }
        }

        void photo_Click(object sender, EventArgs e)
        {
            PhotoIcon photoIco = ((PhotoIcon)sender);
            this.pictureNotes.Visible = false;
            this.txtAuthor.Visible = false;
            this.txtDate.Visible = false;
            this.MainPicture.Image = photoIco.PhotoObject.ImageObject;
            this.pictureNotes.Visible = true;
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
    }
}
