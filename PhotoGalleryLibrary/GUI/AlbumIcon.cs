using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoGalleryLibrary.GUI
{
    public partial class AlbumIcon : UserControl
    {
        private bool isSelected;
        private Album album = null;

        public delegate void AlbumIconClick(object sender, EventArgs e);
        public event AlbumIconClick AlbumClick;

        public AlbumIcon()
        {
            InitializeComponent();
            Selected = false;
        }

        public bool Selected 
        { 
            get 
            { 
                return this.isSelected; 
            } 
            set 
            { 
                this.isSelected = value;

                if (value == true)
                {
                    this.pictureSelected.Visible = true;
                }
                else
                {
                    this.pictureSelected.Visible = false;
                }
            }
        }

        public Album AlbumObject
        {
            get { return this.album; }

            set
            {
                this.album = value;

                if (value != null)
                {
                    this.txtTitle.Text = album.vtitle;
                    this.pictureMain.Image = album.vmainimage;
                }
            }
        }

        public string Title
        {
            get
            {
                return this.txtTitle.Text;
            }

            set
            {
                this.txtTitle.Text = value;
            }
        }

        public Image MainImage
        {
            get
            {
                return this.pictureMain.Image;
            }

            set
            {
                this.pictureMain.Image = value;
            }
        }

        private void pictureMain_Click(object sender, EventArgs e)
        {
            AlbumClick(this, e);
        }

        private void txtTitle_Click(object sender, EventArgs e)
        {
            AlbumClick(this, e);
        }

        private void AlbumIcon_Click(object sender, EventArgs e)
        {
            AlbumClick(this, e);
        }
    }
}
