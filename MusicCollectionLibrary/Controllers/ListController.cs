using Microsoft.AspNetCore.Mvc;
using MusicCollectionLibrary.Data;
using MusicCollectionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCollectionLibrary.Controllers
{
    public class ListController : Controller
    {
        private AlbumDbContext context;
        public ListController(AlbumDbContext DbContext)
        {
            context = DbContext;
        }

        public IActionResult Index()
        {
            List<Album> albums = context.Albums.ToList();
            return View(albums);
        }

        public IActionResult List()
        {
            ViewBag.albums = context.Albums.ToList();
            return View();
        }
    }
}