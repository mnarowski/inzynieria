using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoGalleryLibrary.Exceptions
{
    public class NonSelectedAlbumException: Exception
    {
        public NonSelectedAlbumException()
            : base()
        {
        }

        public NonSelectedAlbumException(string Message)
            : base(Message)
        {
        }
    }
}
