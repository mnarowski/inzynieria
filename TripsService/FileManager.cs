using System;
using PhotoGalleryLibrary;

namespace TripsService {
	public class FileManager : IManager  {

        private static FileManager instance = new FileManager();

        private FileManager() {
			
		}
		public bool SaveFileForUser(User user, String filename) {
            FileAdapter<User> forUser = new FileAdapter<User>();

            return true;
		}
		public bool SaveFileForTrip(Trip trip, String filename) {
            FileAdapter<Trip> forTrip = new FileAdapter<Trip>();

            return true;
		}
		public String[] GetFilesForUser(User user) {
            FileAdapter<User> adapter = new FileAdapter<User>();

            return new string[] { };
		}
		public String[] GetFilesForTrip(Trip trip) {
            FileAdapter<Trip> adapter = new FileAdapter<Trip>();

            return new string[] { };
		}
		public Photo SavePhoto(Photo photo) {
            FileAdapter<Photo> adapter = new FileAdapter<Photo>();

            return new Photo(".");
		}
		public bool SavePhotoToAlbum(Album album, Photo photo) {
            FileAdapter<Album> adapter = new FileAdapter<Album>();

            return true;
		}
		public static IManager GetStaticInstance() {
            return FileManager.instance;
		}


		public bool IsEnabled() {
            return true;
		}



        public IManager GetInstance()
        {
            return FileManager.instance;
        }
    }

}
