﻿using Microsoft.AspNetCore.Mvc;
using MusicCollectionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCollectionLibrary.Controllers
{
    public class AlbumsController : Controller
    {
        static private List<Album> Albums = new List<Album>();
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
        public IActionResult NewAlbum(string firstname, string lastname, string groupname, string albumtitle, string genre, string format)
        {
            Albums.Add(new Album(firstname, lastname, groupname, albumtitle, genre, format));

            return Redirect("/Albums");
        }

    }
}