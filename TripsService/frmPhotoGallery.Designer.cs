namespace TripsService
{
    partial class frmPhotoGallery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhotoGallery));
            this.photoGallery1 = new PhotoGalleryLibrary.GUI.PhotoGallery();
            this.SuspendLayout();
            // 
            // photoGallery1
            // 
            this.photoGallery1.BackColor = System.Drawing.Color.White;
            this.photoGallery1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoGallery1.GalleryObject = ((PhotoGalleryLibrary.AlbumsManager)(resources.GetObject("photoGallery1.GalleryObject")));
            this.photoGallery1.Location = new System.Drawing.Point(0, 1);
            this.photoGallery1.MinimumSize = new System.Drawing.Size(460, 300);
            this.photoGallery1.Name = "photoGallery1";
            this.photoGallery1.Size = new System.Drawing.Size(692, 434);
            this.photoGallery1.TabIndex = 0;
            // 
            // frmPhotoGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 435);
            this.Controls.Add(this.photoGallery1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPhotoGallery";
            this.Text = "Galeria zdjęć";
            this.ResumeLayout(false);

        }

        #endregion

        private PhotoGalleryLibrary.GUI.PhotoGallery photoGallery1;
    }
}