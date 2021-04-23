using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_LAb.Manager.Interfaces;
using EF_LAb.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_LAb.Controllers
{
    public class SelectionsController : Controller
    {
        private IMovieManager _movieManager;
        private ISelectionManager _selectionManager;

        public SelectionsController(IMovieManager movieManager,
            ISelectionManager selectionManager)
        {
            _movieManager = movieManager;
            _selectionManager = selectionManager;
        }

        #region Index
        [HttpGet]
        public async Task<ViewResult> Index()
        {

            List<Selection> selections = await _selectionManager.GetSelectionsAll();


            return View(selections);
        }
        #endregion

        #region Show
        [HttpGet]
        public async Task<ViewResult> Show(int Id)
        {
            Selection selection = await _selectionManager.GetSelection(Id);
            return View(selection);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Selection selection)
        {
            Selection sl = await _selectionManager.AddSelection(selection);

            return RedirectToAction("Show", "Selections", new { Id = sl.Id });

        }
        #endregion

        #region Update
        [HttpGet]
        public async Task<ViewResult> Update(int Id)
        {
            Selection selection = await _selectionManager.GetSelection(Id);

            return View(selection);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Selection selection)
        {
            Selection sl = await _selectionManager.EditSelection(selection);

            return RedirectToAction("Show", "Selections", new { Id = sl.Id });

        }
        #endregion

        #region Delete
        [HttpPost]
        public async Task<ActionResult> Delete(int Id)
        {
            Selection sl = await _selectionManager.RemoveSelection(Id);

            return RedirectToAction("Index", "Selections");

        }
        #endregion


        #region AddMovieToSelection
        [HttpPost]
        public async Task<ActionResult> AddMovieToSelection(string MovieName, string MovieYear, int SelectionId)
        {
            Movie movie = await _movieManager.GetMovieByNameAndYear(MovieName, Int32.Parse(MovieYear));

            if (movie == null)
            {
                movie = await _movieManager.AddMovie(new Movie { Name = MovieName, Year = Int32.Parse(MovieYear) });
            }

            Selection sl = await _selectionManager.AddMovieToSelection(movie, SelectionId);

            return RedirectToAction("Show", "Selections", new { Id = sl.Id });

        }
        #endregion

        #region RemoveMovieToSelection
        [HttpPost]
        public async Task<ActionResult> RemoveMovieFromSelection(int MovieId, int SelectionId)
        {
            Selection sl = await _selectionManager.RemoveMovieFromSelection(MovieId, SelectionId);

            return RedirectToAction("Show", "Selections", new { Id = sl.Id });

        }
        #endregion


    }
}
