using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_LAb.Manager.Interfaces;
using EF_LAb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_LAb.Controllers
{
    public class MediaController : Controller
    {
        private IMovieManager _movieManager;
        private IMediaManager _mediaManager;

        public MediaController(IMovieManager movieManager, IMediaManager mediaManager)
        {
            _movieManager = movieManager;
            _mediaManager = mediaManager;
        }

        #region Index
        [HttpGet]
        public async Task<ViewResult> Index()
        {
            List<Media> media = await _mediaManager.GetMediaAll();

            return View(media);
        }
        #endregion

        #region Show
        [HttpGet]
        public async Task<ViewResult> Show(int Id)
        {
            Media media = await _mediaManager.GetMedia(Id);

            return View(media);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Media media, string MovieId)
        {

            Movie movie = await _movieManager.GetMovie(Int32.Parse(MovieId));
            

            if (movie == null)
            {
                return RedirectToAction("Index", "Media");
            }

            //media.Movie = movie;
            Media md = await _mediaManager.AddMedia(movie, media);

            return RedirectToAction("Show", "Media", new { Id = md.Id });

        }
        #endregion

        #region Update
        [HttpGet]
        public async Task<ViewResult> Update(int Id)
        {
            Media media = await _mediaManager.GetMedia(Id);

            return View(media);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Media media)
        {
            Media md = await _mediaManager.EditMedia(media);

            return RedirectToAction("Show", "Media", new { Id = md.Id });

        }
        #endregion

        #region Delete
        [HttpPost]
        public async Task<ActionResult> Delete(int Id)
        {
            Media md = await _mediaManager.RemoveMedia(Id);

            return RedirectToAction("Index", "Media");

        }
        #endregion
    }
}
