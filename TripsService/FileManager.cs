using System;
using PhotoGalleryLibrary;

namespace TripsService
{

    public class FileManager : IManager
    {
        /// <summary>
        /// Instancja singletone'a
        /// </summary>
        private static FileManager instance = new FileManager();
        /// <summary>
        /// Klasa odpowiadaj¹ca za zarz¹dzanie plikami
        /// </summary>
        private FileManager()
        {

        }
        /// <summary>
        /// Zapisuje plik z danymi u¿ytkownika na dysk
        /// </summary>
        public bool SaveFileForUser(User user, String filename)
        {

            FileAdapter<User> forUser = new FileAdapter<User>();
            return true;
        }
        /// <summary>
        /// Zapisuje plik z danymi wycieczki na dysk
        /// </summary>
        public bool SaveFileForTrip(Trip trip, String filename)
        {
            /// <summary>
            /// Opis
            /// </summary>
            FileAdapter<Trip> forTrip = new FileAdapter<Trip>();
            /// <summary>
            /// Opis
            /// </summary>
            return true;
        }
        /// <summary>
        /// Zwraca nazwy plików dla danego u¿ytkownika
        /// </summary>
        public String[] GetFilesForUser(User user)
        {

            return new string[] { };
        }
        /// <summary>
        /// Zwraca nazwy plików dla danej wycieczki
        /// </summary>
        public String[] GetFilesForTrip(Trip trip)
        {
            FileAdapter<Trip> adapter = new FileAdapter<Trip>();
            return new string[] { };
        }
        /// <summary>
        /// Zapisuje plik z danymi danego zdjêcia
        /// </summary>
        public Photo SavePhoto(Photo photo)
        {
            FileAdapter<Photo> adapter = new FileAdapter<Photo>();
            return new Photo(".");
        }
        /// <summary>
        /// Dodaje zdjêcie do danego albumu i zapisuje na dysku
        /// </summary>
        public bool SavePhotoToAlbum(Album album, Photo photo)
        {
            FileAdapter<Album> adapter = new FileAdapter<Album>();
            return true;
        }
        /// <summary>
        /// Zwraca instancjê singletone'a
        /// </summary>
        public static IManager GetStaticInstance()
        {
            return FileManager.instance;
        }


        public bool IsEnabled()
        {
            return true;
        }



        public IManager GetInstance()
        {
            return FileManager.instance;
        }
    }

}


