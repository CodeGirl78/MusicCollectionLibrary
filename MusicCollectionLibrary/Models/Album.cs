﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCollectionLibrary.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GroupName { get; set; }
        public string AlbumTitle { get; set; }
        public string Genre { get; set; }
        public string AlbumFormat { get; set; }

        public Album()
        {
        }

        public Album(string firstname, string lastname, string groupname, string albumtitle, string genre, string format)
        {
            FirstName = firstname;
            LastName = lastname;
            GroupName = groupname;
            AlbumTitle = albumtitle;
            Genre = genre;
            AlbumFormat = format;
        }

        public override string ToString()
        {
            return AlbumTitle;

        }

        public override bool Equals(object obj)
        {
            return obj is Album @album &&
                   Id == @album.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}