using MusicCollectionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCollectionLibrary.Data
{
    public class AlbumData
    {
        // Store albums
        static private Dictionary<int, Album> Albums = new Dictionary<int, Album>();

        // Add albums
        public static void Add(Album newAlbum)
        {
            Albums.Add(newAlbum.Id, newAlbum);
        }

        // Retrieve all albums
        public static IEnumerable<Album> GetAll()
        {
            return Albums.Values;
        }

        //Retrieve a single album
        public static Album GetById(int id)
        {
            return Albums[id];
        }

        // Remove an album from collection

    }
}