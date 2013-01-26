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
        private Image imgPhoto;
        private string strTitle;
        private string strDescribe;
        private DateTime dtDateAdded;
        private string strAuthor;

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
        /// <param name="Photo">Image object to load</param>
        public Photo(Image Photo)
            : this()
        {
            this.imgPhoto = Photo;
        }

        #endregion

        #region Properties

        public Image ImageObject { get { return this.imgPhoto; } set { this.imgPhoto = value; } }
        public string Title { get { return this.strTitle; } set { this.strTitle = value; } }
        public string Describe { get { return this.strDescribe; } set { this.strDescribe = value; } }
        public DateTime DateAdded { get { return this.dtDateAdded; } set { this.dtDateAdded = value; } }
        public string Author { get { return this.strAuthor; } set { this.strAuthor = value; } }

        #endregion

        #region Functions

        /// <summary>
        /// Method to resize ImageObject to new size (width, height)
        /// </summary>
        /// <param name="width">New image's width</param>
        /// <param name="height">New image's height</param>
        public void ResizeTo(int width, int height)
        {
            int orginalWidth = this.ImageObject.Width;
            int orginalHeight = this.ImageObject.Height;

            Bitmap bmp = new Bitmap(width, height);

            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            graphic.DrawImage(this.imgPhoto, 0, 0, width, height);     
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
            int orginalWidth = photo.ImageObject.Width;
            int orginalHeight = photo.ImageObject.Height;

            Bitmap bmp = new Bitmap(width, height);

            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            graphic.DrawImage(photo.imgPhoto, 0, 0, width, height);

            return photo;
        }

        /// <summary>
        /// Method to zoom in ImageObject
        /// </summary>
        /// <param name="percent">Percent by which zoom in the photo</param>
        public void ZoomInAbout(int percent)
        {
            int orginalWidth = this.ImageObject.Width;
            int orginalHeight = this.ImageObject.Height;

            int resizedWidth = orginalWidth + (int)(orginalWidth * percent / 100);
            int resizedHeight = orginalHeight + (int)(orginalHeight * percent / 100);

            Bitmap bmp = new Bitmap(resizedWidth, resizedHeight);

            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            graphic.DrawImage(this.imgPhoto, 0, 0, resizedWidth, resizedHeight);
        }

        /// <summary>
        /// Method to zoom out ImageObject
        /// </summary>
        /// <param name="percent">Percent by which zoom out the photo</param>
        public void ZoomOutAbout(int percent)
        {
            int orginalWidth = this.ImageObject.Width;
            int orginalHeight = this.ImageObject.Height;

            int resizedWidth = orginalWidth - (int)(orginalWidth * percent / 100);
            int resizedHeight = orginalHeight - (int)(orginalHeight * percent / 100);

            Bitmap bmp = new Bitmap(resizedWidth, resizedHeight);

            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            graphic.DrawImage(this.imgPhoto, 0, 0, resizedWidth, resizedHeight);
        }

        /// <summary>
        /// Static method to zoom in Photo object
        /// </summary>
        /// <param name="photo">Photo object to zoom in</param>
        /// <param name="percent">Percent by which zoom in the photo</param>
        /// <returns></returns>
        static public Photo ZoomInAbout(Photo photo, int percent)
        {
            int orginalWidth = photo.ImageObject.Width;
            int orginalHeight = photo.ImageObject.Height;

            int resizedWidth = orginalWidth + (int)(orginalWidth * percent / 100);
            int resizedHeight = orginalHeight + (int)(orginalHeight * percent / 100);

            Bitmap bmp = new Bitmap(resizedWidth, resizedHeight);

            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            graphic.DrawImage(photo.imgPhoto, 0, 0, resizedWidth, resizedHeight);

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
            int orginalWidth = photo.ImageObject.Width;
            int orginalHeight = photo.ImageObject.Height;

            int resizedWidth = orginalWidth - (int)(orginalWidth * percent / 100);
            int resizedHeight = orginalHeight - (int)(orginalHeight * percent / 100);

            Bitmap bmp = new Bitmap(resizedWidth, resizedHeight);

            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            graphic.DrawImage(photo.imgPhoto, 0, 0, resizedWidth, resizedHeight);

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
    }
}
