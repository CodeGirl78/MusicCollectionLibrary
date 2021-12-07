using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCollectionLibrary.Controllers
{
    public class AlbumsController : Controller
    {
        static private List<string> Albums = new List<string>();
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<string> Events = new List<string>();
            Albums.Add("Jonny Lang");
            Albums.Add("Jim Brickman");
            Albums.Add("Dolly Parton");

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