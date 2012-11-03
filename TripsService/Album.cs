using System;
using System.Runtime.Serialization;
namespace TripsService {
	public class Album : AlbumManager  {
		private String name;
		private User owner;
		private Photo[] photos;

		public String GetName() {
			return this.name;
		}
		public void SetName(String name) {
			this.name = name;
		}
		public User GetOwner() {
			return this.owner;
		}
		public void SetOwner(User owner) {
			this.owner = owner;
		}
		public bool IsPublicVisible() {
			throw new System.Exception("Not implemented");
		}
		public Photo[] GetPhotos() {
			return this.photos;
		}
		public void AddPhotos(Photo[] photos) {
			throw new System.Exception("Not implemented");
		}
		public void AddPhoto(Photo photo) {
			throw new System.Exception("Not implemented");
		}
		public void DeletePhotos() {
			throw new System.Exception("Not implemented");
		}
		public void DeleteAlbum() {
			throw new System.Exception("Not implemented");
		}


	}

}
