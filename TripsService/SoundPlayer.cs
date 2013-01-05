using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TripsService
{
    public partial class SoundPlayer : Form
    {
        public SoundPlayer()
        {
            InitializeComponent();
        }
        string[] files, paths;
        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (MP3Files.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = MP3Files.SafeFileNames;
                paths = MP3Files.SafeFileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    Playlist.Items.Add(files[i]);
                }
            }
        }

        private void Playlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            WindowsMediaPlayer.URL = paths[Playlist.SelectedIndex];
        }
    }
}
