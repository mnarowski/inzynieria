using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoGalleryLibrary
{
    interface IPhotosManagement
    {
        void AddPhoto(Photo item);

        void AddPhotos(params Photo[] items);

        void DeletePhoto(Photo item);

        void DeletePhotos(params Photo[] items);

        void DeleteAllPhotos();
    }
}
