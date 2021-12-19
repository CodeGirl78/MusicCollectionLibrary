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
    public class AlbumsController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            List<Album> albums = new List<Album>(AlbumData.GetAll());

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

                AlbumData.Add(newAlbum);

                return Redirect("/Albums");
            }

            return View(addAlbumViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.albums = AlbumData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] albumIds)
        {
            foreach (int albumId in albumIds)
            {
                AlbumData.Remove(albumId);
            }

            return Redirect("/Albums");
        }
    }
}