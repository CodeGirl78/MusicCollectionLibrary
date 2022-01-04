using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicCollectionLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace MusicCollectionLibrary.Data
{
    public class AlbumDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public AlbumDbContext(DbContextOptions<AlbumDbContext> options)
              : base(options)
        {
        }
    }
}