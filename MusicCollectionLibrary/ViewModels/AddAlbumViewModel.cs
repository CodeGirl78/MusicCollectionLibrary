using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCollectionLibrary.ViewModels
{
    public class AddAlbumViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GroupName { get; set; }
        public string AlbumTitle { get; set; }
        public string Genre { get; set; }
        public string AlbumFormat { get; set; }
    }
}