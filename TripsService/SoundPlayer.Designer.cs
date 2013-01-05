namespace TripsService
{
    partial class SoundPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundPlayer));
            this.tableSP = new System.Windows.Forms.TableLayoutPanel();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Playlist = new System.Windows.Forms.ListBox();
            this.OpenFile = new System.Windows.Forms.Button();
            this.MP3Files = new System.Windows.Forms.OpenFileDialog();
            this.tableSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSP
            // 
            this.tableSP.ColumnCount = 1;
            this.tableSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSP.Controls.Add(this.WindowsMediaPlayer, 0, 0);
            this.tableSP.Controls.Add(this.Playlist, 0, 1);
            this.tableSP.Controls.Add(this.OpenFile, 0, 2);
            this.tableSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSP.Location = new System.Drawing.Point(0, 0);
            this.tableSP.Name = "tableSP";
            this.tableSP.RowCount = 3;
            this.tableSP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableSP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSP.Size = new System.Drawing.Size(284, 262);
            this.tableSP.TabIndex = 0;
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(3, 3);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(278, 102);
            this.WindowsMediaPlayer.TabIndex = 0;
            // 
            // Playlist
            // 
            this.Playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Playlist.FormattingEnabled = true;
            this.Playlist.Location = new System.Drawing.Point(3, 111);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(278, 102);
            this.Playlist.TabIndex = 1;
            this.Playlist.SelectedIndexChanged += new System.EventHandler(this.Playlist_SelectedIndexChanged);
            // 
            // OpenFile
            // 
            this.OpenFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenFile.Location = new System.Drawing.Point(3, 219);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(278, 40);
            this.OpenFile.TabIndex = 2;
            this.OpenFile.Text = "Open";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // MP3Files
            // 
            this.MP3Files.FileName = "mp3files";
            this.MP3Files.Filter = "MP3 Files|\".mp3|WAV Files|\".wav";
            // 
            // SoundPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableSP);
            this.Name = "SoundPlayer";
            this.Text = "SoundPlayer";
            this.tableSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSP;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.ListBox Playlist;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.OpenFileDialog MP3Files;
    }
}