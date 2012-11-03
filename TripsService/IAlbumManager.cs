using System;
namespace TripsService {
	public interface IAlbumManager : IManager  {
		void AddAlbum(Album album);
		void AddAlbums(Album[] albums);
		bool HasAlbum(Album album);
		void DeleteAlbum(Album album);
		void ClearAlbums();
		// method getInstance is inherited from base class

		// method isEnabled is inherited from base class


	}

}
