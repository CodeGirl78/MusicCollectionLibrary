using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicCollectionLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient.Server;

namespace MusicCollectionLibrary.Data
{
    public class AlbumDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Album> Albums { get; set; }
        public AlbumDbContext(DbContextOptions<AlbumDbContext> options)
              : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
        }
    }
}