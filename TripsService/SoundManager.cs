using System;
namespace TripsService {
	public class SoundManager {

        private SoundPlayer mSoundPlayer = null;

		private SoundManager() {
			throw new System.Exception("Not implemented");
		}
		public bool Play(String resource) {
            if (mSoundPlayer == null) {
                mSoundPlayer = new SoundPlayer();
            }

            return true;
        }
		public void Stop() {
			throw new System.Exception("Not implemented");
		}
        ///
		public bool IsEnabled() {
            return true;
		}
		public static IManager GetInstance() {
			throw new System.Exception("Not implemented");
		}
		public bool Pause() {
			throw new System.Exception("Not implemented");
		}


    }

}
