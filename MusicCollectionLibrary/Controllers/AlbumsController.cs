using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCollectionLibrary.Controllers
{
    public class AlbumsController : Controller
    {
        private static List<string> Albums = new List<string>();
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.albums = Albums;

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Albums/Add")]
        public IActionResult NewAlbum(string firstname)
        {
            Albums.Add(firstname);

            return Redirect("/Albums");
        }

    }
}