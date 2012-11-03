using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace TripsService {
	public class AlbumManager : IAlbumManager, ISerializable  {
		private List<Album> album;

		public List<Album> GetAlbums() {
			throw new System.Exception("Not implemented");
		}
		public bool IsEnabled() {
			throw new System.Exception("Not implemented");
		}
		public IManager GetInstance() {
			throw new System.Exception("Not implemented");
		}
		public void ClearAlbums() {
			throw new System.Exception("Not implemented");
		}
		public void DeleteAlbum(Album album) {
			throw new System.Exception("Not implemented");
		}
		public bool HasAlbum(Album album) {
			throw new System.Exception("Not implemented");
		}
		public void AddAlbums(Album[] albums) {
			throw new System.Exception("Not implemented");
		}
		public void AddAlbum(Album album) {
			throw new System.Exception("Not implemented");
		}


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }

}
