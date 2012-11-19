using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PhotoGalleryLibrary
{
    [Serializable]
    public class AlbumsManager: IAlbumsManagement, IDisposable, ISerializable 
    {
        private List<Album> listAlbums = null;  

        #region Properties

        public List<Album> Albums { get { return this.listAlbums; } set { this.listAlbums = value; } }

        #endregion

        #region Constructors

        /// <summary>
        /// No-arguments constructor 
        /// </summary>
        public AlbumsManager()
        {
            this.listAlbums = new List<Album>();
        }

        /// <summary>
        /// Construcor
        /// </summary>
        /// <param name="albums">Albums object to add to the albums collection</param>
        public AlbumsManager(params Album [] albums): this()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Functions 

        /// <summary>
        /// Method to add album
        /// </summary>
        /// <param name="album">Album object to add to the album's collection</param>
        public void AddAlbum(Album album)
        {
            if (this.Albums == null)
            {
                this.Albums = new List<Album>();
            }

            this.Albums.Add(album);
        }

        /// <summary>
        /// Method to add albums
        /// </summary>
        /// <param name="albums">Albums object to add to the album's collection</param>
        public void AddAlbums(params Album[] albums)
        {
            if (this.Albums == null)    
            {
                this.Albums = new List<Album>();
            }

            foreach (Album item in albums)
            {
                this.Albums.Add(item);
            }
        }

        /// <summary>
        /// Method to delete album
        /// </summary>
        /// <param name="album">Album object to delete from album's collection</param>
        public void DeleteAlbum(Album album)
        {
            if (this.Albums != null)
            {
                this.Albums.Remove(album);
            }
        }

        /// <summary>
        /// Method to delete albums 
        /// </summary>
        /// <param name="albums">Album objects to delete from album's collection</param>
        public void DeleteAlbums(params Album [] albums)
        {
            if (this.Albums != null)
            {
                foreach (Album alb in albums)
                {
                    this.Albums.Remove(alb);
                }
            }
        }

        /// <summary>
        /// Method to delete all albums from album's collection
        /// </summary>
        public void DeleteAllAlbums()
        {
            if (this.Albums != null)
            {
                this.Albums.Clear();
            }
        }

        #endregion

        #region Additional functions

        public override string ToString()
        {
            return base.ToString();
        }

        public virtual void Dispose()
        {
            this.listAlbums.Clear();
            this.listAlbums = null;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
