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
            Albums.Add("Jonny Lang");
            Albums.Add("Jim Brickman");
            Albums.Add("Dolly Parton");
            ViewBag.albums = Albums;

            return View();
        }
    }
}