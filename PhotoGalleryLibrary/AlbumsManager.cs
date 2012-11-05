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
        List<Album> listAlbums = null;  

        #region Properties

        public List<Album> Albums { get { return this.listAlbums; } set { this.listAlbums = value; } }

        #endregion

        #region Constructors

        public AlbumsManager()
        {
            this.listAlbums = new List<Album>();
        }

        public AlbumsManager(params Album [] albums): this()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Functions 

        public void AddAlbum(Album album)
        {
            if (this.Albums == null)
            {
                this.Albums = new List<Album>();
            }

            this.Albums.Add(album);
        }

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

        public void DeleteAlbum(Album album)
        {
            if (this.Albums != null)
            {
                this.Albums.Remove(album);
            }
        }

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

        #endregion

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
