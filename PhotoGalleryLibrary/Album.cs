using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;

namespace PhotoGalleryLibrary
{
    [Serializable]
    public class Album: IPhotosManagement, IDisposable, ISerializable
    {
        List<Photo> listPhotos;
        Image imgMainImage;
        string strTitle;
        string strDescribe;
        DateTime dtDateAdded;
        string strAuthor;

        #region Constructors

        private Album()
        {
            this.listPhotos = new List<Photo>();
            this.strTitle = string.Empty;
            this.strDescribe = string.Empty;
            this.dtDateAdded = DateTime.Now;
            this.strAuthor = string.Empty;
        }

        public Album(string title)
            : this()
        {
            this.strTitle = title;
        }

        public Album(string title, string describe)
            : this(title)
        {
            this.strDescribe = describe;
        }

        public Album(string title, string describe, string author)
            : this(title, describe)
        {
            this.strAuthor = author;
        }

        #endregion

        #region Properties

        public List<Photo> Photos { get { return this.listPhotos; } }
        public string Title { get { return this.strTitle; } set { this.strTitle = value; } }
        public string Describe { get { return this.strDescribe; } set { this.strDescribe = value; } }
        public DateTime DateAdded { get { return this.dtDateAdded; } }
        public string Author { get { return this.strAuthor; } set { this.strAuthor = value; } }
        public Image MainImage { get { return this.imgMainImage; } set { this.imgMainImage = value; } }

        #endregion

        #region Functions

        public void AddPhoto(Photo item)
        {
            this.listPhotos.Add(item);
        }

        public void DeletePhoto(Photo item)
        {
            this.listPhotos.Remove(item);
        }

        public void AddPhotos(params Photo[] items)
        {
            this.listPhotos.AddRange(items);
        }

        public void DeletePhotos(params Photo[] items)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllPhotos()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Additional functions

        public override string ToString()
        {
            return this.Title;
        }

        public void Dispose()
        {
            this.listPhotos.Clear();
            this.listPhotos = null;
            this.strTitle = null;
            this.strDescribe = null;
            this.strAuthor = null;
        }

        #endregion

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
