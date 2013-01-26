using System;
using TripsService;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace TripsService {
	public class SoundManager {
        private static WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private string resource = string.Empty;
        private static SoundManager instance = new SoundManager();
        
        protected SoundManager() {
            player.PlayStateChange +=
        new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(Player_PlayStateChange);
            player.MediaError +=
                new WMPLib._WMPOCXEvents_MediaErrorEventHandler(Player_MediaError);
        }

		public void Stop() {
            this.Player_PlayStateChange((int)WMPLib.WMPPlayState.wmppsStopped);
		}
        
        ///
		public bool IsEnabled() {
            return true;
		}
		public static SoundManager GetInstance() {
            
            return instance;

        }
		public bool Pause() {
            player.controls.pause();
            this.Player_PlayStateChange((int)WMPLib.WMPPlayState.wmppsPaused);
            return true;
        }

        public void Play(string resource) {
            this.resource = resource;
            player.URL = resource;
            player.controls.play();
        }

        private void Player_PlayStateChange(int NewState)
        {
            if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
            {
                player.close();
            }
        }

        private void Player_MediaError(object pMediaObject)
        {
            MessageBox.Show("Cannot open plaer");
        }
    }

}
