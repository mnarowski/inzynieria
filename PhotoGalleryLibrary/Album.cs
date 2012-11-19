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
        private List<Photo> listPhotos;
        private Image imgMainImage;
        private string strTitle;
        private string strDescribe;
        private DateTime dtDateAdded;
        private string strAuthor;

        #region Constructors

        /// <summary>
        /// No-arguments constructor
        /// </summary>
        private Album()
        {
            this.listPhotos = new List<Photo>();
            this.strTitle = string.Empty;
            this.strDescribe = string.Empty;
            this.dtDateAdded = DateTime.Now;
            this.strAuthor = string.Empty;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title">Album's title</param>
        public Album(string title)
            : this()
        {
            this.strTitle = title;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title">Albums's title</param>
        /// <param name="describe">Album's describe</param>
        public Album(string title, string describe)
            : this(title)
        {
            this.strDescribe = describe;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title">Album's title</param>
        /// <param name="describe">Album's describe</param>
        /// <param name="author">Album's author</param>
        public Album(string title, string describe, string author)
            : this(title, describe)
        {
            this.strAuthor = author;
        }

        #endregion

        #region Properties

        public List<Photo> Photos { get { return this.listPhotos; } } //readonly
        public string Title { get { return this.strTitle; } set { this.strTitle = value; } }
        public string Describe { get { return this.strDescribe; } set { this.strDescribe = value; } }
        public DateTime DateAdded { get { return this.dtDateAdded; } }  //readonly
        public string Author { get { return this.strAuthor; } set { this.strAuthor = value; } }
        public Image MainImage { get { return this.imgMainImage; } set { this.imgMainImage = value; } }

        #endregion

        #region Functions

        /// <summary>
        /// Method to add the photo to album
        /// </summary>
        /// <param name="item">Photo object to add</param>
        public void AddPhoto(Photo item)
        {
            this.listPhotos.Add(item);
        }

        /// <summary>
        /// Method to delete the photo
        /// </summary>
        /// <param name="item">Photo object to delete</param>
        public void DeletePhoto(Photo item)
        {
            this.listPhotos.Remove(item);
        }

        /// <summary>
        /// Method to add photos 
        /// </summary>
        /// <param name="items">Photo objects to add</param>
        public void AddPhotos(params Photo[] items)
        {
            this.listPhotos.AddRange(items);
        }

        /// <summary>
        /// Method to delete photos 
        /// </summary>
        /// <param name="items">Photo objects to delete</param>
        public void DeletePhotos(params Photo[] items)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method to delete all photos
        /// </summary>
        public void DeleteAllPhotos()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Additional functions

        /// <summary>
        /// Method ToString from class Object
        /// </summary>
        /// <returns>Album's title</returns>
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
