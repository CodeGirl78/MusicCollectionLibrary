using Microsoft.AspNetCore.Mvc;
using MusicCollectionLibrary.Data;
using MusicCollectionLibrary.Models;
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

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add (Album newAlbum)
        {
            AlbumData.Add(newAlbum);

            return Redirect("/Albums");
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