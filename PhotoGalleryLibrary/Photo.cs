using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;

namespace PhotoGalleryLibrary
{
    [Serializable]
    public class Photo: IDisposable, ISerializable
    {
        Image imgPhoto;
        string strTitle;
        string strDescribe;
        DateTime dtDateAdded;
        string strAuthor;

        #region Constructors

        /// <summary>
        /// Private constructor to use by other constructors (not to use by library user)
        /// </summary>
        private Photo()
        {
            this.strTitle = string.Empty;
            this.strDescribe = string.Empty;
            this.strAuthor = string.Empty;
            this.dtDateAdded = DateTime.Now;
        }

        /// <summary>
        /// Constructor load photo from file.
        /// </summary>
        /// <param name="PathToPhoto">Path to photo.</param>
        public Photo(string PathToPhoto)
            : this()
        {
            this.imgPhoto = Image.FromFile(PathToPhoto);
        }

        /// <summary>
        /// Constructor load photo from Image object
        /// </summary>
        /// <param name="Photo"></param>
        public Photo(Image Photo)
            : this()
        {
            this.imgPhoto = Photo;
        }

        #endregion

        #region Properties

        public Image Image { get { return this.imgPhoto; } set { this.imgPhoto = value; } }
        public string Title { get { return this.strTitle; } set { this.strTitle = value; } }
        public string Describe { get { return this.strDescribe; } set { this.strDescribe = value; } }
        public DateTime DateAdded { get { return this.dtDateAdded; } set { this.dtDateAdded = value; } }
        public string Author { get { return this.strAuthor; } set { this.strAuthor = value; } }

        #endregion

        #region Additional Functions

        public override string ToString()
        {
            return this.Title;
        }

        public void Dispose()
        {
            imgPhoto = null;
            strTitle = null;
            strDescribe = null;
            strAuthor = null;
        }

        #endregion

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
