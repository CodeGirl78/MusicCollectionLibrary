using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCollectionLibrary.ViewModels
{
    public class AddAlbumViewModel
    {
        [StringLength(50, MinimumLength = 1)]
        public string FirstName { get; set; }
        [StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; }
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Group Name must be between 3 and 100 characters")]
        public string GroupName { get; set; }
        [Required(ErrorMessage = "Album Title is required.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Album Title must be between 3 and 150 characters")]
        public string AlbumTitle { get; set; }
        public string Genre { get; set; }
        public string AlbumFormat { get; set; }
    }
}