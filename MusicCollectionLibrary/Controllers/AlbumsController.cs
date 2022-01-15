using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MusicCollectionLibrary.Data;
using MusicCollectionLibrary.Models;
using MusicCollectionLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCollectionLibrary.Controllers
{
    [Authorize]
    public class AlbumsController : Controller
    {
        private AlbumDbContext context;
        public AlbumsController(AlbumDbContext DbContext)
        {
            context = DbContext;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            List<Album> albums = context.Albums.ToList();

            return View(albums);
        }

        public IActionResult Add()
        {
            AddAlbumViewModel addAlbumViewModel = new AddAlbumViewModel();
            return View(addAlbumViewModel);
        }

        [HttpPost]
        public IActionResult Add (AddAlbumViewModel addAlbumViewModel)
        {
            if (ModelState.IsValid)
            {
                Album newAlbum = new Album
                {
                    FirstName = addAlbumViewModel.FirstName,
                    LastName = addAlbumViewModel.LastName,
                    GroupName = addAlbumViewModel.GroupName,
                    AlbumTitle = addAlbumViewModel.AlbumTitle,
                    Genre = addAlbumViewModel.Genre,
                    Format = addAlbumViewModel.Format,
                };

                context.Albums.Add(newAlbum);
                context.SaveChanges();

                return Redirect("/Albums");
            }

            return View(addAlbumViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.albums = context.Albums.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] albumIds)
        {
            foreach (int albumId in albumIds)
            {
                Album theAlbum = context.Albums.Find(albumId);
                context.Albums.Remove(theAlbum);

            }

            context.SaveChanges();

            return Redirect("/Albums");
        }
    }
}