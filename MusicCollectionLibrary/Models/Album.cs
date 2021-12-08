using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCollectionLibrary.Models
{
    public class Album
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GroupName { get; set; }
        public string AlbumTitle { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }


        public Album(string firstname, string lastname, string groupname, string albumtitle, string genre, string format)
        {
            FirstName = firstname;
            LastName = lastname;
            GroupName = groupname;
            AlbumTitle = albumtitle;
            Genre = genre;
            Format = format;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}