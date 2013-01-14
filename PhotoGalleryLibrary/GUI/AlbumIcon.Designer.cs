namespace PhotoGalleryLibrary.GUI
{
    partial class AlbumIcon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumIcon));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.pictureMain = new System.Windows.Forms.PictureBox();
            this.pictureSelected = new PhotoGalleryLibrary.GUI.TranparentPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTitle.Location = new System.Drawing.Point(-1, 121);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(180, 14);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitle.Click += new System.EventHandler(this.txtTitle_Click);
            // 
            // pictureMain
            // 
            this.pictureMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureMain.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureMain.ErrorImage")));
            this.pictureMain.Location = new System.Drawing.Point(-1, -1);
            this.pictureMain.Name = "pictureMain";
            this.pictureMain.Size = new System.Drawing.Size(180, 116);
            this.pictureMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMain.TabIndex = 1;
            this.pictureMain.TabStop = false;
            this.pictureMain.Click += new System.EventHandler(this.pictureMain_Click);
            // 
            // pictureSelected
            // 
            this.pictureSelected.Image = global::PhotoGalleryLibrary.Properties.Resources.Map_Marker_Push_Pin_1_Left_Pink_icon;
            this.pictureSelected.Location = new System.Drawing.Point(-1, -1);
            this.pictureSelected.Name = "pictureSelected";
            this.pictureSelected.Size = new System.Drawing.Size(36, 35);
            this.pictureSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSelected.TabIndex = 2;
            this.pictureSelected.TabStop = false;
            // 
            // AlbumIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureSelected);
            this.Controls.Add(this.pictureMain);
            this.Controls.Add(this.txtTitle);
            this.MinimumSize = new System.Drawing.Size(180, 140);
            this.Name = "AlbumIcon";
            this.Size = new System.Drawing.Size(178, 139);
            this.Click += new System.EventHandler(this.AlbumIcon_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.PictureBox pictureMain;
        private TranparentPictureBox pictureSelected;
    }
}
