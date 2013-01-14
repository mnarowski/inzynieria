﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoGalleryLibrary
{
    public partial class frmPhotoFullScreen : Form
    {
        public frmPhotoFullScreen()
        {
            InitializeComponent();
        }

        public frmPhotoFullScreen(Image photoToShowInFullScreen)
        {
            InitializeComponent();
            this.pbFullScreen.Image = photoToShowInFullScreen;
        }

        private void pbFullScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhotoFullScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
