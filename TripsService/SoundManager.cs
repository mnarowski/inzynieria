using System;
using TripsService;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace TripsService {
	public class SoundManager {
        /// <summary>
        /// Na jakie cuda 2 klasa publiczna w 1 pliku!!
        /// </summary>
        class MP3_File
        {
            FileInfo info = null;

            public string PathToMP3 { get { return this.info.FullName.ToString(); } }

            public MP3_File(FileInfo fileMp3)
            {
                this.info = fileMp3;
            }

            public override string ToString()
            {
                return this.info.Name.ToString();
            }
        }
        private string sPathToPlaylist = string.Empty;

		public SoundManager(string pathToPlayList) {
            this.sPathToPlaylist = pathToPlayList;
		}

        public List<MP3_File> GetPlaylist()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(this.sPathToPlaylist);
            List<MP3_File> files = new List<MP3_File>();

            foreach (FileInfo file in dirInfo.GetFiles())
            {
                files.Add(new MP3_File(file));
            }

            return files;
        }
        public bool IsEnabled()
        {
            return true;
        }
		public void Stop() {
            //Wiec daj kod tutaj!!!!
			//Obs³uga przez Windows Media Player
		}
        
        ///
		public bool IsEnabled() {
            return true;
		}
		public static IManager GetInstance() {
            //Co to niby ma byæ?
			throw new System.Exception("Not implemented");
		}
		public bool Pause() {
            //co to niby ma byæ?
			throw new System.Exception("Not implemented");
		}


    }

}
