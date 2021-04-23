using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_LAb.Manager.Interfaces;
using EF_LAb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_LAb.Controllers
{
    public class GenresController : Controller
    {
        private IGenreManager _genreManager;

        public GenresController(IGenreManager genreManager)
        {
            _genreManager = genreManager;
        }

        #region Index
        [HttpGet]
        public async Task<ViewResult> Index()
        {
            List<Genre> genres = await _genreManager.GetGenresAll();

            return View(genres);
        }
        #endregion

        #region Show
        [HttpGet]
        public async Task<ViewResult> Show(int Id)
        {
            Genre genre = await _genreManager.GetGenre(Id);

            return View(genre);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Genre genre)
        {

            Genre ge = await _genreManager.AddGenre(genre);

            return RedirectToAction("Show", "Genres", new { Id = ge.Id });

        }
        #endregion

        #region Update
        [HttpGet]
        public async Task<ViewResult> Update(int Id)
        {
            Genre genre = await _genreManager.GetGenre(Id);

            return View(genre);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Genre genre)
        {
            Genre ge = await _genreManager.EditGenre(genre);

            return RedirectToAction("Show", "Genres", new { Id = ge.Id });

        }
        #endregion

        #region Delete
        [HttpPost]
        public async Task<ActionResult> Delete(int Id)
        {
            Genre ge = await _genreManager.RemoveGenre(Id);

            return RedirectToAction("Index", "Genres");

        }
        #endregion
    }
}
