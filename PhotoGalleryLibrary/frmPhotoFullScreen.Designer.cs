namespace PhotoGalleryLibrary
{
    partial class frmPhotoFullScreen
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
            this.pbFullScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFullScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFullScreen
            // 
            this.pbFullScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFullScreen.Location = new System.Drawing.Point(0, 0);
            this.pbFullScreen.Name = "pbFullScreen";
            this.pbFullScreen.Size = new System.Drawing.Size(513, 376);
            this.pbFullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFullScreen.TabIndex = 0;
            this.pbFullScreen.TabStop = false;
            this.pbFullScreen.Click += new System.EventHandler(this.pbFullScreen_Click);
            // 
            // frmPhotoFullScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 376);
            this.Controls.Add(this.pbFullScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhotoFullScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhotoFullScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPhotoFullScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFullScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFullScreen;
    }
}