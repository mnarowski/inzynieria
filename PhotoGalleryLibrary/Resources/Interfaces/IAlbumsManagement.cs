using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoGalleryLibrary
{
    interface IAlbumsManagement
    {
        void AddAlbum(Album album);

        void AddAlbums(params Album[] albums);

        void DeleteAlbum(Album album);

        void DeleteAlbums(params Album[] albums);

        void DeleteAllAlbums();
    }
}
