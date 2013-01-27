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
    public partial class PhotoIcon : UserControl
    {
        Photo image = null;

        public delegate void PhotoIconClick(object sender, EventArgs e);
        public event PhotoIconClick PhotoClick;

        public PhotoIcon()
        {
            InitializeComponent();
        }

        public Photo PhotoObject
        {
            get
            {
                return this.image;
            }

            set
            {
                this.image = value;

                if (image != null)
                {
                    if (image.vimageobject != null)
                    {
                        this.pictureBox1.Image = image.vimageobject;
                    }
                }
            }
        }

        public Image ImageObject
        {
            get
            {
                return this.pictureBox1.Image;
            }

            set
            {
                this.pictureBox1.Image = value;
            }
        }

        private void PhotoIcon_Click(object sender, EventArgs e)
        {
            PhotoClick(this, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PhotoClick(this, e);
        }
    }
}
