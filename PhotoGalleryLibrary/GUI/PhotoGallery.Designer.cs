namespace PhotoGalleryLibrary.GUI
{
    partial class PhotoGallery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoGallery));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelAlbums = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.MainPicture = new System.Windows.Forms.PictureBox();
            this.panelPhotos = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewAlbum = new System.Windows.Forms.ToolStripButton();
            this.txtDate = new PhotoGalleryLibrary.GUI.TranparenLabel();
            this.txtAuthor = new PhotoGalleryLibrary.GUI.TranparenLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.panelAlbums);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(959, 601);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelAlbums
            // 
            this.panelAlbums.AutoScroll = true;
            this.panelAlbums.BackColor = System.Drawing.Color.White;
            this.panelAlbums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlbums.Controls.Add(this.toolStrip1);
            this.panelAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlbums.Location = new System.Drawing.Point(0, 0);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(258, 601);
            this.panelAlbums.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.txtDate);
            this.splitContainer2.Panel1.Controls.Add(this.txtAuthor);
            this.splitContainer2.Panel1.Controls.Add(this.txtTitle);
            this.splitContainer2.Panel1.Controls.Add(this.MainPicture);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelPhotos);
            this.splitContainer2.Size = new System.Drawing.Size(697, 601);
            this.splitContainer2.SplitterDistance = 482;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTitle.Location = new System.Drawing.Point(0, 456);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(697, 19);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainPicture
            // 
            this.MainPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MainPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPicture.Location = new System.Drawing.Point(0, 0);
            this.MainPicture.Name = "MainPicture";
            this.MainPicture.Size = new System.Drawing.Size(697, 444);
            this.MainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPicture.TabIndex = 0;
            this.MainPicture.TabStop = false;
            this.MainPicture.DoubleClick += new System.EventHandler(this.MainPicture_DoubleClick);
            // 
            // panelPhotos
            // 
            this.panelPhotos.AutoScroll = true;
            this.panelPhotos.BackColor = System.Drawing.Color.White;
            this.panelPhotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhotos.Location = new System.Drawing.Point(0, 0);
            this.panelPhotos.Name = "panelPhotos";
            this.panelPhotos.Size = new System.Drawing.Size(697, 115);
            this.panelPhotos.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewAlbum});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(256, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewAlbum
            // 
            this.btnNewAlbum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNewAlbum.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAlbum.Image")));
            this.btnNewAlbum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewAlbum.Name = "btnNewAlbum";
            this.btnNewAlbum.Size = new System.Drawing.Size(70, 22);
            this.btnNewAlbum.Text = "Dodaj album";
            this.btnNewAlbum.Click += new System.EventHandler(this.btnNewAlbum_Click);
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDate.Location = new System.Drawing.Point(610, 462);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(84, 13);
            this.txtDate.TabIndex = 8;
            this.txtDate.Text = "tranparenLabel1";
            this.txtDate.Visible = false;
            // 
            // txtAuthor
            // 
            this.txtAuthor.AutoSize = true;
            this.txtAuthor.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAuthor.Location = new System.Drawing.Point(-3, 457);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(84, 13);
            this.txtAuthor.TabIndex = 7;
            this.txtAuthor.Text = "tranparenLabel1";
            this.txtAuthor.Visible = false;
            // 
            // PhotoGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "PhotoGallery";
            this.Size = new System.Drawing.Size(959, 601);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelAlbums.ResumeLayout(false);
            this.panelAlbums.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox MainPicture;
        private System.Windows.Forms.Panel panelAlbums;
        private System.Windows.Forms.Panel panelPhotos;
        private System.Windows.Forms.TextBox txtTitle;
        private TranparenLabel txtDate;
        private TranparenLabel txtAuthor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewAlbum;
    }
}
