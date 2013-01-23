namespace TripsService
{
    partial class TripInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripInfoForm));
          //  this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label1 = new System.Windows.Forms.Label();
            this.photoGallery1 = new PhotoGalleryLibrary.GUI.PhotoGallery();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTrip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLocalisation = new System.Windows.Forms.TextBox();
            this.textBoxAtractions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atrakcje:";
            // 
            // photoGallery1
            // 
            this.photoGallery1.BackColor = System.Drawing.Color.White;
            this.photoGallery1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoGallery1.GalleryObject = ((PhotoGalleryLibrary.AlbumsManager)(resources.GetObject("photoGallery1.GalleryObject")));
            this.photoGallery1.Location = new System.Drawing.Point(37, 106);
            this.photoGallery1.MinimumSize = new System.Drawing.Size(760, 400);
            this.photoGallery1.Name = "photoGallery1";
            this.photoGallery1.Size = new System.Drawing.Size(760, 400);
            this.photoGallery1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wyprawa:";
            // 
            // textBoxTrip
            // 
            this.textBoxTrip.Location = new System.Drawing.Point(359, 41);
            this.textBoxTrip.Name = "textBoxTrip";
            this.textBoxTrip.Size = new System.Drawing.Size(157, 20);
            this.textBoxTrip.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Galeria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lokalizacja:";
            // 
            // textBoxLocalisation
            // 
            this.textBoxLocalisation.Location = new System.Drawing.Point(456, 546);
            this.textBoxLocalisation.Multiline = true;
            this.textBoxLocalisation.Name = "textBoxLocalisation";
            this.textBoxLocalisation.Size = new System.Drawing.Size(362, 153);
            this.textBoxLocalisation.TabIndex = 7;
            // 
            // textBoxAtractions
            // 
            this.textBoxAtractions.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxAtractions.Location = new System.Drawing.Point(24, 546);
            this.textBoxAtractions.Multiline = true;
            this.textBoxAtractions.Name = "textBoxAtractions";
            this.textBoxAtractions.Size = new System.Drawing.Size(362, 153);
            this.textBoxAtractions.TabIndex = 8;
            // 
            // TripInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 715);
            this.Controls.Add(this.textBoxAtractions);
            this.Controls.Add(this.textBoxLocalisation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.photoGallery1);
            this.Controls.Add(this.label1);
            this.Name = "TripInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trip Info";
            this.Load += new System.EventHandler(this.TripInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label label1;
        private PhotoGalleryLibrary.GUI.PhotoGallery photoGallery1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLocalisation;
        private System.Windows.Forms.TextBox textBoxAtractions;

    }
}