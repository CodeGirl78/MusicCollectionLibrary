using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCollectionLibrary.Models
{
    public class Album
    {
        public string FirstName { get; set; }

        public Album(string firstname)
        {
            FirstName = firstname;
        }
    }
}