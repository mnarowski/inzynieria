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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkNewAlbum = new System.Windows.Forms.LinkLabel();
            this.panelAlbums = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new PhotoGalleryLibrary.GUI.TranparenLabel();
            this.linkNewPhoto = new System.Windows.Forms.LinkLabel();
            this.txtDate = new PhotoGalleryLibrary.GUI.TranparenLabel();
            this.MainPicture = new System.Windows.Forms.PictureBox();
            this.panelPhotos = new System.Windows.Forms.Panel();
            this.cmAlbum = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmPhoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).BeginInit();
            this.cmAlbum.SuspendLayout();
            this.cmPhoto.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.panelAlbums);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(692, 434);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkNewAlbum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 28);
            this.panel1.TabIndex = 1;
            // 
            // linkNewAlbum
            // 
            this.linkNewAlbum.AutoSize = true;
            this.linkNewAlbum.Location = new System.Drawing.Point(3, 5);
            this.linkNewAlbum.Name = "linkNewAlbum";
            this.linkNewAlbum.Size = new System.Drawing.Size(65, 13);
            this.linkNewAlbum.TabIndex = 0;
            this.linkNewAlbum.TabStop = true;
            this.linkNewAlbum.Text = "Nowy album";
            this.linkNewAlbum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNewAlbum_LinkClicked);
            // 
            // panelAlbums
            // 
            this.panelAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAlbums.AutoScroll = true;
            this.panelAlbums.BackColor = System.Drawing.Color.White;
            this.panelAlbums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlbums.Location = new System.Drawing.Point(0, 27);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(206, 408);
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
            this.splitContainer2.Panel1.Controls.Add(this.txtTitle);
            this.splitContainer2.Panel1.Controls.Add(this.txtAuthor);
            this.splitContainer2.Panel1.Controls.Add(this.linkNewPhoto);
            this.splitContainer2.Panel1.Controls.Add(this.txtDate);
            this.splitContainer2.Panel1.Controls.Add(this.MainPicture);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelPhotos);
            this.splitContainer2.Size = new System.Drawing.Size(482, 434);
            this.splitContainer2.SplitterDistance = 347;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTitle.Location = new System.Drawing.Point(7, 323);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(398, 19);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAuthor
            // 
            this.txtAuthor.AutoSize = true;
            this.txtAuthor.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAuthor.Location = new System.Drawing.Point(7, 8);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(34, 14);
            this.txtAuthor.TabIndex = 7;
            this.txtAuthor.Text = "Autor";
            this.txtAuthor.Visible = false;
            // 
            // linkNewPhoto
            // 
            this.linkNewPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkNewPhoto.AutoSize = true;
            this.linkNewPhoto.Location = new System.Drawing.Point(408, 328);
            this.linkNewPhoto.Name = "linkNewPhoto";
            this.linkNewPhoto.Size = new System.Drawing.Size(71, 13);
            this.linkNewPhoto.TabIndex = 9;
            this.linkNewPhoto.TabStop = true;
            this.linkNewPhoto.Text = "Nowe zdjęcie";
            this.linkNewPhoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNewPhoto_LinkClicked);
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDate.Location = new System.Drawing.Point(412, 8);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(63, 14);
            this.txtDate.TabIndex = 8;
            this.txtDate.Text = "2012-11-12";
            this.txtDate.Visible = false;
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
            this.MainPicture.Size = new System.Drawing.Size(483, 319);
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
            this.panelPhotos.Size = new System.Drawing.Size(482, 83);
            this.panelPhotos.TabIndex = 0;
            // 
            // cmAlbum
            // 
            this.cmAlbum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmAlbum.Name = "cmAlbum";
            this.cmAlbum.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edytuj";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Usuń";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cmPhoto
            // 
            this.cmPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.cmPhoto.Name = "cmAlbum";
            this.cmPhoto.Size = new System.Drawing.Size(153, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Edytuj";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Usuń";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // PhotoGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(460, 300);
            this.Name = "PhotoGallery";
            this.Size = new System.Drawing.Size(692, 434);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).EndInit();
            this.cmAlbum.ResumeLayout(false);
            this.cmPhoto.ResumeLayout(false);
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
        private System.Windows.Forms.LinkLabel linkNewPhoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkNewAlbum;
        private System.Windows.Forms.ContextMenuStrip cmAlbum;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmPhoto;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}
