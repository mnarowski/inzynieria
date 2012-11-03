using System;
namespace TripsService {
	public class FileManager : IManager  {
		private FileManager() {
			throw new System.Exception("Not implemented");
		}
		public bool SaveFileForUser(User user, String filename) {
			throw new System.Exception("Not implemented");
		}
		public bool SaveFileForTrip(Trip trip, String filename) {
			throw new System.Exception("Not implemented");
		}
		public String[] GetFilesForUser(User user) {
			throw new System.Exception("Not implemented");
		}
		public String[] GetFilesForTrip(Trip trip) {
			throw new System.Exception("Not implemented");
		}
		public Photo SavePhoto(Photo photo) {
			throw new System.Exception("Not implemented");
		}
		public bool SavePhotoToAlbum(Album album, Photo photo) {
			throw new System.Exception("Not implemented");
		}
		public IManager GetInstance() {
			throw new System.Exception("Not implemented");
		}
		public bool IsEnabled() {
			throw new System.Exception("Not implemented");
		}

	}

}
