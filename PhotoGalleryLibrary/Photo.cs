using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;

namespace PhotoGalleryLibrary
{
    [Serializable]
    public class Photo: IDisposable
    {
        private int m_iID;
        private Image m_oPhoto;
        private string m_sTitle;
        private string m_sDescribe;
        private DateTime m_oDateAdded;
        private string m_sAuthor;
        private string m_sImagePath;

        #region Constructors

        /// <summary>
        /// Private constructor to use by other constructors (not to use by library user)
        /// </summary>
        private Photo()
        {
            this.m_sTitle = string.Empty;
            this.m_sDescribe = string.Empty;
            this.m_sAuthor = string.Empty;
            this.m_oDateAdded = DateTime.Now;
        }

        /// <summary>
        /// Constructor load photo from file.
        /// </summary>
        /// <param name="PathToPhoto">Path to photo.</param>
        public Photo(string PathToPhoto)
            : this()
        {
            this.m_oPhoto = Image.FromFile(PathToPhoto);
        }

        /// <summary>
        /// Constructor load photo from Image object
        /// </summary>
        /// <param name="Photo">Image object to load</param>
        public Photo(Image Photo)
            : this()
        {
            this.m_oPhoto = Photo;
        }

        #endregion

        #region Properties

        public int vid { get { return this.m_iID; } set { this.m_iID = value; } }
        public Image vimageobject { get { return this.m_oPhoto; } set { this.m_oPhoto = value; } }
        public string vimagepath { get { return this.m_sImagePath; } set { this.m_sImagePath = value; this.m_oPhoto = System.Drawing.Image.FromFile(value); } }
        public string vtitle { get { return this.m_sTitle; } set { this.m_sTitle = value; } }
        public string vdescription { get { return this.m_sDescribe; } set { this.m_sDescribe = value; } }
        public DateTime vdateadded { get { return this.m_oDateAdded; } set { this.m_oDateAdded = value; } }
        public string vauthor { get { return this.m_sAuthor; } set { this.m_sAuthor = value; } }

        #endregion

        #region Functions

        /// <summary>
        /// Method to resize ImageObject to new size (width, height)
        /// </summary>
        /// <param name="width">New image's width</param>
        /// <param name="height">New image's height</param>
        public void ResizeTo(int width, int height)
        {
            int orginalWidth = this.vimageobject.Width;
            int orginalHeight = this.vimageobject.Height;

            Bitmap bmp = new Bitmap(width, height);

            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            graphic.DrawImage(this.m_oPhoto, 0, 0, width, height);     
        }

        /// <summary>
        /// Static method to resize Photo object
        /// </summary>
        /// <param name="photo">Photo object to resize</param>
        /// <param name="width">New photo's width</param>
        /// <param name="height">New photo's height</param>
        /// <returns></returns>
        static public Photo ResizeTo(Photo photo, int width, int height)
        {
            int orginalWidth = photo.vimageobject.Width;
            int orginalHeight = photo.vimageobject.Height;

            Bitmap bmp = new Bitmap(width, height);

            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            graphic.DrawImage(photo.m_oPhoto, 0, 0, width, height);

            return photo;
        }

        /// <summary>
        /// Method to zoom in ImageObject
        /// </summary>
        /// <param name="percent">Percent by which zoom in the photo</param>
        public void ZoomInAbout(int percent)
        {
            int orginalWidth = this.vimageobject.Width;
            int orginalHeight = this.vimageobject.Height;

            int resizedWidth = orginalWidth + (int)(orginalWidth * percent / 100);
            int resizedHeight = orginalHeight + (int)(orginalHeight * percent / 100);

            Bitmap bmp = new Bitmap(resizedWidth, resizedHeight);

            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            graphic.DrawImage(this.m_oPhoto, 0, 0, resizedWidth, resizedHeight);
        }

        /// <summary>
        /// Method to zoom out ImageObject
        /// </summary>
        /// <param name="percent">Percent by which zoom out the photo</param>
        public void ZoomOutAbout(int percent)
        {
            int orginalWidth = this.vimageobject.Width;
            int orginalHeight = this.vimageobject.Height;

            int resizedWidth = orginalWidth - (int)(orginalWidth * percent / 100);
            int resizedHeight = orginalHeight - (int)(orginalHeight * percent / 100);

            Bitmap bmp = new Bitmap(resizedWidth, resizedHeight);

            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            graphic.DrawImage(this.m_oPhoto, 0, 0, resizedWidth, resizedHeight);
        }

        /// <summary>
        /// Static method to zoom in Photo object
        /// </summary>
        /// <param name="photo">Photo object to zoom in</param>
        /// <param name="percent">Percent by which zoom in the photo</param>
        /// <returns></returns>
        static public Photo ZoomInAbout(Photo photo, int percent)
        {
            int orginalWidth = photo.vimageobject.Width;
            int orginalHeight = photo.vimageobject.Height;

            int resizedWidth = orginalWidth + (int)(orginalWidth * percent / 100);
            int resizedHeight = orginalHeight + (int)(orginalHeight * percent / 100);

            Bitmap bmp = new Bitmap(resizedWidth, resizedHeight);

            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            graphic.DrawImage(photo.m_oPhoto, 0, 0, resizedWidth, resizedHeight);

            return photo;
        }

        /// <summary>
        /// Static method to zoom out Photo object
        /// </summary>
        /// <param name="photo">Photo object to zoom out</param>
        /// <param name="percent">Percent by which zoom out the photo</param>
        /// <returns></returns>
        static public Photo ZoomInOut(Photo photo, int percent)
        {
            int orginalWidth = photo.vimageobject.Width;
            int orginalHeight = photo.vimageobject.Height;

            int resizedWidth = orginalWidth - (int)(orginalWidth * percent / 100);
            int resizedHeight = orginalHeight - (int)(orginalHeight * percent / 100);

            Bitmap bmp = new Bitmap(resizedWidth, resizedHeight);

            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            graphic.DrawImage(photo.m_oPhoto, 0, 0, resizedWidth, resizedHeight);

            return photo;
        }

        #endregion

        #region Additional Functions

        /// <summary>
        /// Method from class Object
        /// </summary>
        /// <returns>Photo's title</returns>
        public override string ToString()
        {
            return this.vtitle;
        }

        public void Dispose()
        {
            m_oPhoto = null;
            m_sTitle = null;
            m_sDescribe = null;
            m_sAuthor = null;
        }


        #endregion
    }
}
