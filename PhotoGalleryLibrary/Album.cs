using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;
using PhotoGalleryLibrary.DB;

namespace PhotoGalleryLibrary
{
    [Serializable]
    public class Album : IPhotosManagement, IDisposable
    {
        private int m_iID;
        private List<Photo> m_loPhotos;
        private Image m_oMainImage;
        private string m_sTitle;
        private string m_sDescribe;
        private DateTime m_oDateAdded;
        private string m_sAuthor;
        private string m_sMainImagePath;

        #region Constructors

        /// <summary>
        /// No-arguments constructor
        /// </summary>
        public Album()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title">Album's title</param>
        public Album(string title)
            : this()
        {
            this.m_sTitle = title;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title">Albums's title</param>
        /// <param name="describe">Album's describe</param>
        public Album(string title, string describe)
            : this(title)
        {
            this.m_sDescribe = describe;
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
            this.m_sAuthor = author;
        }

        #endregion

        #region Properties

        public virtual int vid { get { return this.m_iID; } set { this.m_iID = value; } }
        public virtual List<Photo> vphotos //readonly
        {
            get
            {
                NHibernate.ISession session = SessionFactory.GetNewSession();
                string sql = "from Photo p WHERE p.valbumid = :albumid";

                NHibernate.IQuery query = session.CreateQuery(sql);
                query = query.SetParameter("albumid", this.vid);

                return query.List<Photo>().ToList<Photo>();
            }
        }
        public virtual string vtitle { get { return this.m_sTitle; } set { this.m_sTitle = value; } }
        public virtual string vdescribe { get { return this.m_sDescribe; } set { this.m_sDescribe = value; } }
        public virtual DateTime vdateadded { get { return this.m_oDateAdded; } }  //readonly
        public virtual string vauthor { get { return this.m_sAuthor; } set { this.m_sAuthor = value; } }
        public virtual Image vmainimage { get { return this.m_oMainImage; } set { this.m_oMainImage = value; } }
        public virtual string vmainimagepath { get { return this.m_sMainImagePath; } set { this.m_sMainImagePath = value; this.m_oMainImage = System.Drawing.Image.FromFile(value); } }

        #endregion

        #region Functions

        /// <summary>
        /// Method to add the photo to the album
        /// </summary>
        /// <param name="item">Photo object to add</param>
        public virtual void AddPhoto(Photo item)
        {
            if (this.vphotos == null)
            {
                this.m_loPhotos = new List<Photo>();
            }

            this.vphotos.Add(item);

            DbService.Add<Photo>(item);
        }

        /// <summary>
        /// Method to delete the photo
        /// </summary>
        /// <param name="item">Photo object to delete</param>
        public virtual void DeletePhoto(Photo item)
        {
            if (this.vphotos != null)
            {
                this.vphotos.Remove(item);
                DbService.Delete<Photo>(item);
            }
        }

        /// <summary>
        /// Method to add photos 
        /// </summary>
        /// <param name="items">Photo objects to add</param>
        public virtual void AddPhotos(params Photo[] items)
        {
            if (vphotos == null)
            {
                this.m_loPhotos = new List<Photo>();
            }

            this.vphotos.AddRange(items);
        }

        /// <summary>
        /// Method to delete photos 
        /// </summary>
        /// <param name="items">Photo objects to delete</param>
        public virtual void DeletePhotos(params Photo[] items)
        {
            if (this.vphotos != null)
            {
                foreach (Photo item in items)
                {
                    this.vphotos.Remove(item);

                }
            }
        }

        /// <summary>
        /// Method to delete all photos
        /// </summary>
        public virtual void DeleteAllPhotos()
        {
            if (this.vphotos != null)
            {
                this.vphotos.Clear();
            }
        }

        #endregion

        #region Additional functions

        /// <summary>
        /// Method ToString from class Object
        /// </summary>
        /// <returns>Album's title</returns>
        public override string ToString()
        {
            return this.vtitle;
        }

        public void Dispose()
        {
            this.m_loPhotos.Clear();
            this.m_loPhotos = null;
            this.m_sTitle = null;
            this.m_sDescribe = null;
            this.m_sAuthor = null;
        }


        #endregion
    }
}
